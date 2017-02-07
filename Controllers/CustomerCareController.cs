using Microsoft.AspNetCore.Mvc;
[Route ("customer")]
public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    [Route("claims")]
    public IActionResult Quote()
    {
        return Ok("This is the quote of the CustomerCareController");
    }
    [Route ("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the New claim of the CustomerCareController");
    }
    [Route ("claimstatus")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the Claim History of the CustomerCareController");
    }
}