﻿namespace EventHub.Events
{
    public static class EventConsts
    {
        public const int UrlCodeLength = 8;
        public const int MaxTitleInUrlLength = 60;
        public const int MaxUrlLength = MaxTitleInUrlLength + 1 + UrlCodeLength; //Format: {Title}-{UrlCode}

        public const int MinTitleLength = 8;
        public const int MaxTitleLength = 128;

        public const int MinDescriptionLength = 50;
        public const int MaxDescriptionLength = 2000;
        
        public const int MinLinkLength = 4;
        public const int MaxLinkLength = 2000;
    }
}
