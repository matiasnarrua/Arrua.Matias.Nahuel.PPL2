namespace TiposDeUsuarios
{
    public abstract class Usuario
    {
        private string _user;
        private string _pass;

        public Usuario(string user, string pass)
        {
            this._user = user;
            this._pass = pass;
        }

        public abstract void PrecargarUsuarios(List <Type> lista );
    }
}