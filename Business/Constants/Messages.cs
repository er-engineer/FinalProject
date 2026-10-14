using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully.";
        public static string ProductNameInvalid = "Product name must be at least 2 characters long.";
        public static string ProductsListed = "Products listed successfully.";
        public static string ProductCountOfCategoryError = "A category can have a maximum of 10 products.";
        public static string MaintenanceTime = "System is under maintenance.";
        public static string ProductNameAlreadyExists = "A product with the same name already exists.";
        public static string CategoryLimitExceeded = "Maximum category count must be less than 15. Contact administrator.";
        public static string AuthorizationDenied = "You are not authorized to perform this action.";
        public static string UserRegistered = "User registered successfully.";
        public static string AccessTokenCreated = "Access token created successfully.";
        public static string SuccessfulLogin = "Login successful.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Incorrect password.";
        public static string UserAlreadyExists = "User already exists.";
    }

}
