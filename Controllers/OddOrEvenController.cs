//Harrison Busby
//10/26/2022
//OddOrEven Endpoints
//Peer reviewed by: Peer reviewed by Amardeep Mann: Code works greats for integers both positive and negative! 
//Code is clear and concise- good use of modulo and if/else. 
//We didn't really learn about how to deal with edge cases for API's but if I throw in a string or decimal into the URL it throws an error. 
//You could use a TryParse in a future revision to maybe let the user know they can only enter integers. 
//But I'm sure we'll cover a more elegant solution in class soon. Great work!




using Microsoft.AspNetCore.Mvc;

namespace BusbyHOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("BigTime/{validNumber}")]

    public string NumberTime(int validNumber){
        
       string result = "";
        
       
if(validNumber % 2 == 0){
    result = $"{validNumber} is an even number";
}else{
     result = $" {validNumber} is an odd number";
}

return result;
}
}

