using PWS_1.Model;
using System.Web;
using System.Web.SessionState;

namespace PWS_1.Handlers
{
    public class PutHandler : IHttpHandler, IRequiresSessionState
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            var add = int.Parse(request.Params["ADD"]);
            
            var dataStorage = (Storage)context.Session["Storage"];

            if (dataStorage == null)
            {
                dataStorage = new Storage();
                context.Session["Storage"] = dataStorage;
            }

            dataStorage.Stack.Push(add);
            
            response.Write("Last element from stack: " + add);
        }
    }
}