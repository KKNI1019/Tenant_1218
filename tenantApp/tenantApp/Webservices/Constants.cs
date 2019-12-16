﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tenantApp.Webservices
{
    public static class Constants
    {
        public const string OpenEndpoint = "https://www.googleapis.com/youtube/v3/";
        public const string OpenAPIKey = "AIzaSyCHXTDNV3eidwPOGuBNduAQJx_5kKrsNjE";
        public const string ChannelID = "UCIdluEEVJ9W5RtlgDBAZ7sg";

        public const string SERVER_BASE_URL1 = "http://133.18.218.237:5000/real_estate_management/api/owner/";

        public const string SERVER_BASE_URL = "http://133.18.218.237:5000/real_estate_management/api/user/";
        public const string SERVER_Quiz_URL = "http://133.18.218.237:5000/real_estate_management/question/add";
        public const string ENDPOINT_URL = "http://133.18.218.237:5000/real_estate_management/";
        public const string IMAGE_UPLOAD_URL_PREFIX = "http://133.18.218.237:5000/uploads/profile/owner/";
        public const string IMAGE_UPLOAD_URL_PREFIX_TENANT = "http://133.18.218.237:5000/uploads/profile/tenant/";
        public const string ESTATE_IMAGE_URL_PREFIX = "http://133.18.218.237:5000/uploads/image/estate/";
        public const string SERVER_GET_NEWS_URL = SERVER_BASE_URL + "get_news_info";
        public const string SERVER_REGIST_COMMENT_URL = SERVER_BASE_URL + "regist_news_comment";
        public const string SERVER_LIKE_COMMENT_URL = SERVER_BASE_URL + "like_comment";
        public const string SERVER_DISLIKE_COMMENT_URL = SERVER_BASE_URL + "dislike_comment";
        public const string SERVER_VIDEO_URL = SERVER_BASE_URL + "get_video_info";

        public const string NETWORK_ERROR = "サーバー接続でエラーが発生しました。";

        public const string NEWS_ID = "news_id";
        public const string LAST_NEWS_ID = "last_news_id";
        public const string FAVORITE_NEWS_IDS = "favorite_news_ids";

        public const string TENANT_EMAIL = "tenant_email";
        public const string TENANT_NAME = "tenant_name";
        public const string TENANT_PWD = "tenant_pwd";
        public const string TENANT_REGIST_FROM = "tenant_regist_from";
        public const string REGISTERED = "registered";
        public const string DEVICE_TOKEN = "device_token";
    }
}
