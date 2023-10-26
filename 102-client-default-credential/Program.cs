
// <using_identity_directives> 
using Azure.Core;
using Azure.Identity;
// </using_identity_directives>// <using_directives> 
using Azure.Data.Tables;
// </using_directives>

// <credential>
// Credential class for testing on a local machine or Azure services
TokenCredential credential = new DefaultAzureCredential();
// </credential>

// <default_credential> 
// New instance of TableServiceClient class using a credential
TableServiceClient client = new(
    endpoint: new Uri(Environment.GetEnvironmentVariable("COSMOS_ENDPOINT")!),
    tokenCredential: credential
);
// </default_credential>