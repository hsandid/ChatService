﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Aub.Eece503e.ChatService.Datacontracts;

namespace Aub.Eece503e.ChatService.Client
{
    public interface IChatServiceClient
    {
        Task<UploadImageResponse> UploadImage(Stream stream);
        Task<DownloadImageResponse> DownloadImage(string imageId);
        Task DeleteImage(string imageId);
        Task AddProfile(Profile profile);
        Task<Profile> GetProfile(string username);
        Task DeleteProfile(string username);
        Task UpdateProfile(string username, Profile profile);
        Task<Message> AddMessage(string conversationId, PostMessageRequest message);
        Task<Message> GetMessage(string conversationId, string messageId);
        Task<GetMessagesResponse> GetMessageList(string conversationId, int limit, long lastSeenMessageTime);
        Task<GetMessagesResponse> GetMessageList(string conversationId, string uri);
    }
}
