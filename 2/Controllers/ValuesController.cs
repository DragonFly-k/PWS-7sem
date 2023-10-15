using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using lab2.Models;

namespace lab2.Controllers
{
    public class ValuesController : ApiController
    {

        private static readonly Storage Storage = new();
        public string Get()
        {
            var resultValue = Storage.Result;
            var topStackElement = Storage.Stack.Count > 0 ? Storage.Stack.Peek() : 0;
            if (Storage.Stack.Count == 0)
            {
                return "{\"result\": " + resultValue + "}";
            }
            else
            {
                return "{\"result\": " + (topStackElement+ resultValue) + "}";
            }
        }
        public void Post(int result)
        {
            Storage.Result = result;
        }
        public void Put(int add)
        {
            Storage.Stack.Push(add);
        }
        public void Delete()
        {
            if (Storage.Stack.Count != 0)
            {
                Storage.Stack.Pop();
            }
        }
    }
}
