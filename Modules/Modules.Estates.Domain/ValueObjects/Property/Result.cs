// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Property/PropertyNumber.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/05/2025 12:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.ValueObjects.Property
{
    // public class Result
    // {
    //     public bool IsSuccess { get; }
    //     public string Error { get; }

    //     protected Result(bool isSuccess, string error)
    //     {
    //         IsSuccess = isSuccess;
    //         Error = error;
    //     }

    //     public static Result Success() => new Result(true, null);
    //     public static Result Failure(string error) => new Result(false, error);
    // }

    public class Result<T>
    {
        public bool IsSuccess { get; }
        public string Error { get; }
        public T Value { get; }

        protected Result(bool isSuccess, string error, T value)
        {
            IsSuccess = isSuccess;
            Error = error;
            Value = value;
        }

        public static Result<T> Success(T value) => new Result<T>(true, null, value);
        public static Result<T> Failure(string error) => new Result<T>(false, error, default);
    }
}

