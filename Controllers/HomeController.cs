using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeController");
    }
}

public class AutoController : Controller
{
    public IActionResult Index()
    {
       return Ok("This is the index of the AutoController"); 
    }
    public IActionResult Quote()
    {
       return Ok("This is the quote of the AutoController"); 
    }
}

public class HomesController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomesController");
    }
    public IActionResult Quote()
    {
        return Ok("This is the quote of the HomesController");
    }
}

public class LifeController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the LifeController");
    }
    public IActionResult Quote()
    {
        return Ok("This is the quote of the LifeController");
    }
}
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