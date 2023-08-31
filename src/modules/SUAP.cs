using EMAKE_API.src.client;
using EMAKE_API.src.interfaces;
using FirebaseAdmin;

namespace EMAKE_API.src.modules
{
    public class SUAP : Module
    {
        public string Name;

        public Client Client;
        public SUAP(Client client)
        {
            this.Name = "SUAP";

            this.Client = client;
        }

        public Module Start()
        {
            return this;
        }
    }
}
