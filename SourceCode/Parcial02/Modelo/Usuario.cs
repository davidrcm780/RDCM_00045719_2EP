namespace Parcial02
{
    public class Usuario
    {
        public string fullname
        {
            get; set;
        }

        public string username
        {
            get; set;
        }

        public string paswword
        {
            get; set;
        }

        public bool usertype
        {
            get; set;
        }

        public Usuario()
        {
            fullname = "";
            username = "";
            paswword = "";
            usertype = true;
        }
    }
}