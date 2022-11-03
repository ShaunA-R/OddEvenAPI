using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OddEvenAPI.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class OddEvenController : ControllerBase
    {
        [HttpGet]
        [Route("OddEven/{num1}")]

    public string OddOrEven(string num1)
    {
        if(!int.TryParse(num1, out int num2)) return "Not Valid Number";
        if (num2 % 2 == 0) return $"{num2} is even"; else return $"{num2} is odd";
    }
    }
