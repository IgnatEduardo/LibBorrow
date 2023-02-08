namespace proiectDaw.Helper.JwUtils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(Models.User user);
        public Guid ValidateJwtToken(string token);
    }
}
