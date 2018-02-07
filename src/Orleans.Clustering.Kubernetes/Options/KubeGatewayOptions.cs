using Newtonsoft.Json;

namespace Orleans.Clustering.Kubernetes.Options
{
    public class KubeGatewayOptions
    {
        private const string ORLEANS_NAMESPACE = "orleans";
        private const string ORLEANS_GROUP = "clustering.com";
        private const string KUBE_API_ENDPOINT = "http://kubernetes";

        [JsonProperty(nameof(Namespace))]
        public string Namespace { get; set; } = ORLEANS_NAMESPACE;

        [JsonProperty(nameof(Group))]
        public string Group { get; set; } = ORLEANS_GROUP;

        [JsonProperty(nameof(APIEndpoint))]
        public string APIEndpoint { get; set; } = KUBE_API_ENDPOINT;
    }
}
