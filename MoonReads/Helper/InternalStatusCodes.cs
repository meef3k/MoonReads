namespace MoonReads.Helper
{
    public struct InternalStatusCodes
    {
        #region General

        public const string Success = "SUCCESS";

        #endregion
        
        #region Errors

        public const string CreateError = "CREATE_ERROR";
        public const string EditError = "EDIT_ERROR";
        public const string DeleteError = "DELETE_ERROR";
        public const string InvalidPayload = "INVALID_PAYLOAD";

        #endregion
        
        #region User

        public const string PasswordsNotEqual = "PASSWORDS_NOT_EQUAL";
        public const string InvalidPassword = "INVALID_PASSWORD";
        public const string InvalidLogin = "INVALID_LOGIN";
        public const string InvalidToken = "INVALID_TOKEN";
        public const string InvalidUser = "INVALID_USER";
        public const string InvalidRefreshToken = "INVALID_REFRESH_TOKEN";
        public const string UserCreated = "USER_CREATED";

        #endregion

        #region Entity

        public const string EntityExist = "ENTITY_EXIST";
        public const string EntityNotExist = "ENTITY_NOT_EXIST";
        public const string CannotDeleteEntity = "CANNOT_DELETE_ENTITY";

        #endregion
    }
}
