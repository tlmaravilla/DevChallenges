namespace DevChallenges.Sandbox
{
    // Example of a Parameter Objects, instead of passing both through parm
    public class StorageServiceDetails
    {
        public StorageServiceDetails(string endpointUrl, string apiKey)
        {
            EndpointUrl = endpointUrl;
            ApiKey = apiKey;
        }

        public string EndpointUrl { get; }
        public string ApiKey { get; }
    }
}