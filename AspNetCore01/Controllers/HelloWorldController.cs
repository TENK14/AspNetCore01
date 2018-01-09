using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCore01.Controllers
{
    public class HelloWorldController : Controller
    {
		// 
	    // GET: /HelloWorld/

	    public string Index()
	    {
		    return "This is my default action...";
	    }

		//// 
		//// GET: /HelloWorld/Welcome/ 
		//public string Welcome()
		//{
		//	return "This is the Welcome action method...";
		//}

		//http://localhost:xxxx/HelloWorld/Welcome?name=Rick&numtimes=4
		//// GET: /HelloWorld/Welcome/ 
		//// Requires using System.Text.Encodings.Web;
		//public string Welcome(string name, int numTimes = 1)
		//{
		//	return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
		//}

		//http://localhost:62070/HelloWorld/Welcome/3?name=Rick
		public string Welcome(string name, int ID = 1)
	    {
		    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
	    }
	}
}
