﻿namespace ProductClientHub.Communication.Response
{
    public class ResponseClientJson
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<ResponseShortProductJson> responseShortProducts { get; set; } = [];
        public object Product { get; set; }
    }
}
