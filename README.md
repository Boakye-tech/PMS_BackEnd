# Property Management Solution (PMS) API

A comprehensive property management system built with ASP.NET Core, featuring modular architecture with separate modules for Billing, Customers, Documents, Estates, Facilities, Finance, Legal, Notifications, and User management.

## 🏗️ DevOps & Deployment Architecture

### Environments Overview

The project supports three main deployment environments:

| Environment | Branch | Deployment Target | Database Location | Purpose |
|------------|---------|------------------|------------------|---------|
| **Development** | `develop` | SmarterASP.NET | SmarterASP.NET (existing) | Development testing and integration |
| **Staging** | `staging` | SmarterASP.NET | SmarterASP.NET (fresh/new) | Pre-production testing |
| **Production (Azure Demo)** | `main` | Azure Web App | Dedicated Production DB (fresh/new) | Production environment for client demonstrations |

### 🌐 Environment URLs & Endpoints

#### Development Environment
- **Base URL**: Configured via `BASEURL_DEV` secret
- **Deployment Path**: `/pms-api-dev/` on SmarterASP.NET
- **API Endpoint**: http://mindsprings-002-site3.ltempurl.com/api/v1

#### Staging Environment  
- **Base URL**: Configured via `BASEURL_STAGING` secret
- **Deployment Path**: `/pms-api-staging/` on SmarterASP.NET
- **API Endpoint**: http://mindsprings-002-site4.ltempurl.com/api/v1

#### Production (Azure Demo) Environment
- **Base URL**: Configured via `BASEURL_PRODUCTION` secret
- **Azure Web App**: `pms-api-dev`
- **API Endpoint**: https://pms-api-dev-huhhgvfdhyaxd4cq.westeurope-01.azurewebsites.net/api/v1

### 📋 Available API Modules

The system includes the following modules, each with their own set of endpoints:

- **Billing** - Invoice and billing management
- **Customers** - Customer/tenant management  
- **Documents** - Document storage and management
- **Estates** - Property and estate management
- **Facilities** - Facility management and maintenance
- **Finance** - Financial operations and reporting
- **Legal** - Legal document and contract management
- **Notifications** - SMS, email, and push notifications
- **Users** - User authentication and authorization

### 🚀 CI/CD Pipelines

#### 1. SmarterASP.NET Deployment Pipeline (`main.yaml`)

**Triggers:** 
- Push to `develop` or `staging` branches
- Pull requests to `develop` or `staging`

**Key Features:**
- SonarQube code quality analysis (develop branch only)
- Automated testing with coverage reports
- Database migrations for multiple DbContexts
- Configuration management from templates
- FTP deployment to SmarterASP.NET

**Workflow Steps:**
1. **Code Quality & Security**
   - SonarQube analysis
   - Unit testing with code coverage
   
2. **Configuration Management**
   - Environment-specific settings from `appsettings.tpl.json`
   - Firebase configuration from secrets
   - Dynamic connection string injection
   
3. **Database Operations**
   - **Enhanced Migration Handling**: 
     - Staging branch: Advanced error handling for fresh databases (similar to Azure pipeline)
     - Development branch: Standard migration process
   - **Fresh Database Support**: Graceful handling of index-related migration conflicts
   - **Database Status Checks**: Pre-migration connectivity verification for staging
   - EF Core migrations for all contexts:
     - `Modules.Estates.Infrastructure.ApplicationDbContext`
     - `Modules.Finance.Infrastructure.Data.FinanceDbContext`
     - `Modules.Users.Infrastructure.UserDbContext`
     - `Modules.Notification.Infrastructure.NotificationDbContext`
     - `Modules.Customers.Infrastructure.Persistence.ApplicationDBContext`

4. **Deployment**
   - Build and publish .NET application
   - FTP deployment to environment-specific directories

#### 2. Azure Deployment Pipeline (`main_pms-api-azure.yml`)

**Triggers:**
- Push to `main` branch
- Manual workflow dispatch

**Key Features:**
- Azure Web App deployment
- Production environment configuration
- Dedicated database for Azure deployment
- Environment-specific configuration
- Artifact-based deployment strategy

**Workflow Steps:**
1. **Build Phase**
   - Configuration generation from templates
   - Package dependency resolution
   - Database migration execution
   - Artifact creation

2. **Deploy Phase**
   - Azure Web App deployment using publish profile
   - Production slot deployment

### 🔧 Configuration Management

#### Template Files

**`appsettings.tpl.json`**
Template file containing placeholder configurations for:
- Database connection strings
- JWT token settings
- Email providers (O365, Gmail)
- SMS providers (mNotify, BecSMS)
- Module base URLs
- Logging configuration

**`firebase.tpl.json`**
Template for Firebase service account configuration used for push notifications.

#### Configuration Injection Process

During pipeline execution, the templates are processed and secrets are injected:

1. **Database Connections**: Environment-specific connection strings
2. **Authentication**: JWT token keys
3. **External Services**: 
   - Email service credentials (O365/Gmail)
   - SMS service credentials (mNotify/BecSMS)
   - Firebase service account details
4. **Base URLs**: Environment-specific API base URLs

### 🔐 GitHub Actions Secrets Management

#### Required Secrets Configuration

Navigate to your GitHub repository → Settings → Secrets and variables → Actions

#### Database Secrets
```
DB_CONNECTION_STRING_DEV          # Development database connection
DB_CONNECTION_STRING_STAGING      # Staging database connection  
DB_CONNECTION_STRING_PRODUCTION  # Production database connection (for main branch Azure deployment)
```

**Note**: The main branch deployment to Azure uses a dedicated production database (DB_CONNECTION_STRING_CLIENT_DEMO). This fresh database setup may require handling migration conflicts during the first deployment.

#### Authentication Secrets
```
TOKEN_KEY                         # JWT token signing key
```

#### Base URL Configuration
```
BASEURL_DEV                      # Development environment base URL
BASEURL_STAGING                  # Staging environment base URL
BASEURL_PRODUCTION              # Production environment base URL (for main branch Azure deployment)
```

#### Email Service Secrets (O365)
```
O356MAILSENDER_HOST              # O365 SMTP host
O356MAILSENDER_PORT              # O365 SMTP port
O356MAILSENDER_ENABLESSL         # O365 SSL setting
O356MAILSENDER_USERNAME          # O365 username
O356MAILSENDER_PASSWORD          # O365 password
```

#### Email Service Secrets (Gmail)
```
GMAILSENDER_HOST                 # Gmail SMTP host
GMAILSENDER_PORT                 # Gmail SMTP port
GMAILSENDER_ENABLESSL            # Gmail SSL setting
GMAILSENDER_USERNAME             # Gmail username
GMAILSENDER_PASSWORD             # Gmail app password
```

#### SMS Service Secrets (mNotify)
```
MNOTIFYSMS_BASEURL              # mNotify API base URL
MNOTIFYSMS_USERKEY              # mNotify user key
MNOTIFYSMS_SENDERID             # mNotify sender ID
```

#### SMS Service Secrets (BecSMS)
```
BECSMS_BASEURL                  # BecSMS API base URL
BECSMS_APIKEY                   # BecSMS API key
BECSMS_SENDERID                 # BecSMS sender ID
```

#### Firebase Configuration
```
FIREBASE_JSON_CONTENT           # Complete Firebase service account JSON
```

#### Deployment Secrets (SmarterASP.NET)
```
SERVER_COMPUTER_NAME            # FTP server hostname
SERVER_USERNAME                 # FTP username
SERVER_PASSWORD                 # FTP password
```

#### Azure Deployment Secrets
```
AZUREAPPSERVICE_PUBLISHPROFILE_AF5C5F69112D41808171D0899F3FFD39  # Azure publish profile
```

#### Code Quality Secrets
```
SONAR_TOKEN                     # SonarQube authentication token
```

### 🔄 Database Management

#### Supported Database Contexts

The system uses Entity Framework Core with multiple database contexts:

1. **Estates Context** - Property and estate data
2. **Finance Context** - Financial transactions and reports
3. **Users Context** - User management and authentication
4. **Notifications Context** - Notification history and settings
5. **Customers Context** - Customer/tenant information

#### Migration Strategy

- **Development/Staging**: Automatic migrations during deployment
- **Client Demo (Production)**: Database migrations run against SmarterASP.NET database
- **Pull Requests**: Dry-run migration script generation for review

### 📝 Deployment Guidelines

#### For Development Releases
1. Create feature branch from `develop`
2. Implement changes and commit
3. Create pull request to `develop`
4. Pipeline runs code analysis and tests
5. Merge triggers automatic deployment to dev environment

#### For Staging Releases
1. Create pull request from `develop` to `staging`
2. Review and merge
3. Automatic deployment to staging environment

#### For Production (Azure Demo) Deployments
1. Merge approved changes to `main` branch
2. Azure deployment pipeline automatically triggers
3. Application deployed to Azure Web App (pms-api-dev)
4. Database operations run against dedicated production database
5. Production environment configured with `ASPNETCORE_ENVIRONMENT=Production`

### 🛠️ Development Setup

#### Prerequisites
- .NET 8.0 SDK
- Entity Framework Core tools
- Access to configured databases
- Firebase service account (for notifications)

#### Local Development
```bash
# Clone repository
git clone <repository-url>

# Install EF Core tools
dotnet tool install --global dotnet-ef

# Restore packages
dotnet restore

# Update local database
dotnet ef database update --project PMS.Presentation

# Run application
dotnet run --project PMS.Presentation
```

#### Environment Configuration
Copy `appsettings.tpl.json` to `appsettings.Development.json` and configure with local settings.

### 🔍 Monitoring & Logging

- **Serilog Integration**: Structured logging with file and console outputs
- **Application Insights**: Available for Azure deployments
- **Health Checks**: Endpoint monitoring capabilities
- **Error Tracking**: Centralized error logging and reporting

### 🚨 Troubleshooting

#### Common Issues

**Pipeline Failures:**
- Verify all required secrets are configured
- Check database connection strings
- Ensure Firebase JSON is valid
- Validate FTP credentials for SmarterASP.NET deployment

**Database Migration Issues:**
- Review DbContext configurations
- Check connection string format
- Verify database permissions
- Review migration history

**Fresh Database Setup (Azure Production Environment):**
- When using a new database for main branch deployment, migration conflicts may occur
- The pipeline now includes improved error handling for index-related issues
- Error message `Cannot drop the index 'IX_CustomerTransactions_VoucherNumber', because it does not exist` is common with fresh databases
- The system will continue deployment even if some index operations fail, as the schema will still be functional
- Verify database connectivity using the new "Check Database Status" step in the pipeline

**Database Migration Troubleshooting Steps:**
1. **For Index Errors**: These are typically non-blocking for fresh databases
2. **For Connection Issues**: Verify the `DB_CONNECTION_STRING_[env]` secret
3. **For Permission Issues**: Ensure the database user has CREATE/ALTER/DROP permissions
4. **For Context Issues**: Verify all DbContext classes are properly registered
5. **For Multiple DbContext Errors**: The pipeline now specifies individual contexts to avoid ambiguity
6. **Pipeline Resilience**: Database steps are configured with `continue-on-error: true` to prevent blocking deployment

**Pipeline Improvements for Fresh Database Environments:**

**SmarterASP.NET Pipeline (`main.yaml`):**
- **Staging Branch**: Enhanced database migration with the same robust error handling as Azure pipeline
- **Development Branch**: Standard migration process for existing databases
- **Database Status Check**: Pre-migration connectivity verification for staging environment
- **Adaptive Approach**: Automatically detects fresh vs. existing databases

**Azure Production Pipeline (`main_pms-api-azure.yml`):**
- Database connectivity check now uses specific DbContext to avoid "multiple context" errors
- Enhanced error detection for index-related issues (Error Number: 3701)
- Non-blocking migration process - deployment continues even with minor database issues
- Detailed logging for troubleshooting migration problems
- Application readiness verification step before deployment

**Both Pipelines Now Feature:**
- Graceful handling of index drop errors on non-existent indexes
- `continue-on-error: true` for database operations
- Detailed migration status reporting
- Context-specific error handling

**Configuration Issues:**
- Validate template file syntax
- Ensure all placeholder values are replaced
- Check secret key naming conventions
- Verify environment variable assignments

### 🤝 Contributing

1. Follow the established branching strategy
2. Ensure all tests pass before creating pull requests
3. Update documentation for any configuration changes
4. Follow the code quality standards enforced by SonarQube

---

*This documentation covers the DevOps aspects of the Property Management Solution API. For technical implementation details, refer to the individual module documentation.*