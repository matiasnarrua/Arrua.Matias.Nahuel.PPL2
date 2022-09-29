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

        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }

        public abstract void PrecargarUsuarios(List <Type> lista );
        
    }
}