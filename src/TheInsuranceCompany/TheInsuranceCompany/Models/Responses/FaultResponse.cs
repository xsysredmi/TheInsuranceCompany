namespace TIC.WebAPI.Models.Responses
{
    public class FaultResponse
    {
        public string FaultMessage { get; set; }

        public FaultResponse()
        {
            FaultMessage = "Unfortunately Peanut Butter";
        }
    }
}
