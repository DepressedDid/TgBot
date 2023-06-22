namespace TgBot
{
    public class GifsModel
    {
        public List<Gif> data { get; set; }

        //public async void GifUrlToString(ITelegramBotClient botClient,Message message )
        //{
        //    for (int i = 0; i < data.Count; i++)
        //    {
        //        await botClient.SendDocumentAsync(message.Chat.Id, new InputFileUrl(data[i].Url), caption: "");
        //    }
        //}
    }
    public class Gif
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }
}
