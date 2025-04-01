using System;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Enums;
using Modules.Users.Domain.Entities;

namespace Modules.Users.UnitTest.InfrastructureLayer.Data
{
	public static class UserMasterTestData
	{
        public static List<Channels> GetSampleChannelsData()
        {
            return new List<Channels>
            {
                new Channels(1, "Web"),
                new Channels(2, "Mobile"),
                new Channels(3, "USSD"),
            };
        }


        public static List<Department> GetSampleDepartmentData()
        {
            return new List<Department>
            {
                new Department(1, "Finance"),
                new Department(2, "Estates"),
            };
        }

        public static List<DepartmentUnit> GetSampleDepartmentUnitData()
        {
            return new List<DepartmentUnit>
            {
                new DepartmentUnit(1, 9, "Cash & Bank"),
                new DepartmentUnit(1, 8, "Revenue"),
                new DepartmentUnit(2, 7, "Records"),
                new DepartmentUnit(2, 6, "Serviced Plots")
            };
        }

        public static List<ApplicationIdentityRole> GetSampleRolesData()
        {
            return new List<ApplicationIdentityRole>
            {
                new ApplicationIdentityRole{ Id = "RoleOneId", Name = "RoleOne",NormalizedName="ROLEONE", DepartmentId = 1, UnitId = 9, CreatedBy = "creator1", CreatedOn = DateTime.UtcNow, ApprovedBy = "approver1",ApprovedOn = DateTime.UtcNow, Status = 2},
                new ApplicationIdentityRole{ Id = "RoleTwoId", Name = "RoleTwo",NormalizedName="ROLETWO", DepartmentId = 1, UnitId = 8, CreatedBy = "creator1", CreatedOn = DateTime.UtcNow, ApprovedBy = "approver1",ApprovedOn = DateTime.UtcNow, Status = 2},
                new ApplicationIdentityRole{ Id = "RoleThreeId", Name = "RoleThree",NormalizedName="ROLETHREE", DepartmentId = 2, UnitId = 7, CreatedBy = "creator2", CreatedOn = DateTime.UtcNow, ApprovedBy = "approver2",ApprovedOn = DateTime.UtcNow, Status = 2},
                new ApplicationIdentityRole{ Id = "RoleFourId", Name = "RoleFour",NormalizedName="ROLEFOUR", DepartmentId = 2, UnitId = 6, CreatedBy = "creator2", CreatedOn = DateTime.UtcNow, ApprovedBy = "approver2",ApprovedOn = DateTime.UtcNow, Status = 2}
            };
        }

        public static List<ApplicationIdentityUser> GetSampleApplicationUsersData()
        {
            return new List<ApplicationIdentityUser>
            {
                new ApplicationIdentityUser
                {
                    Id = "creator1",
                    Email = "creator@example.com",
                    UserName = "creator@example.com",
                    FirstName = "Role",
                    MiddleName = "",
                    LastName = "creator",
                    PhoneNumber = "1234567890",
                    Status = (int)RegistrationStatus.Activated,
                    IsFirstTime = false,
                    UserType = (int)UserAccountType.Staff,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    DepartmentId = 1,
                    UnitId = 1,
                    ChannelId = 1,
                    RegistrationDate = DateTime.UtcNow,
                    RefreshToken = null,
                    RefreshTokenExpires = DateTime.UtcNow
                },

                new ApplicationIdentityUser
                {
                    Id = "approver1",
                    Email = "approver@example.com",
                    UserName = "approver@example.com",
                    FirstName = "Role",
                    MiddleName = "",
                    LastName = "approver",
                    PhoneNumber = "1234567890",
                    Status = (int)RegistrationStatus.Activated,
                    IsFirstTime = false,
                    UserType = (int)UserAccountType.Staff,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    DepartmentId = 1,
                    UnitId = 1,
                    ChannelId = 1,
                    RegistrationDate = DateTime.UtcNow,
                    RefreshToken = null,
                    RefreshTokenExpires = DateTime.UtcNow
                },
            };
        }


        public class TestAsyncQueryProvider<TEntity> : IAsyncQueryProvider
        {
            private readonly IQueryProvider _innerQueryProvider;

            public TestAsyncQueryProvider(IQueryProvider innerQueryProvider)
            {
                _innerQueryProvider = innerQueryProvider;
            }

            public IQueryable CreateQuery(Expression expression) => new TestAsyncEnumerable<TEntity>(expression);

            public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
                => new TestAsyncEnumerable<TElement>(expression);

            public object? Execute(Expression expression) => _innerQueryProvider.Execute(expression);

            public TResult Execute<TResult>(Expression expression) => _innerQueryProvider.Execute<TResult>(expression);

            public IAsyncEnumerable<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default)
                => new TestAsyncEnumerable<TResult>(_innerQueryProvider.CreateQuery<TResult>(expression));

            TResult IAsyncQueryProvider.ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
            {
                //return Task.FromResult();
                return Execute<TResult>(expression);
            }

            //TResult IAsyncQueryProvider.ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
            //{
            //    throw new NotImplementedException();
            //}
        }


        public class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
        {
            public TestAsyncEnumerable(IEnumerable<T> enumerable) : base(enumerable) { }
            public TestAsyncEnumerable(Expression expression) : base(expression) { }

            public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
                => new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        public class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
        {
            private readonly IEnumerator<T> _innerEnumerator;

            public TestAsyncEnumerator(IEnumerator<T> innerEnumerator)
            {
                _innerEnumerator = innerEnumerator;
            }

            public ValueTask DisposeAsync() => ValueTask.CompletedTask;

            public ValueTask<bool> MoveNextAsync() => new(_innerEnumerator.MoveNext());

            public T Current => _innerEnumerator.Current;
        }

    }
}

