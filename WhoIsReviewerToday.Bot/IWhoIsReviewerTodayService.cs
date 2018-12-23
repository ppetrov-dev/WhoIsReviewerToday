﻿using Telegram.Bot.Types;

namespace WhoIsReviewerToday.Bot
{
    public interface IWhoIsReviewerTodayService
    {
        void StartBot(string websiteUrl);

        void SendSimpleMessage(ChatId chartId, string text);

        string GetGreetings();
    }
}