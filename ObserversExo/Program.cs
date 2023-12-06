// See https://aka.ms/new-console-template for more information

using ObserversExo.Enums;
using ObserversExo.Models;

WebSite ws = new WebSite();
Magazine m = new Magazine();

Client c = new Client("JP");

ws.AddSubscribe(c);

m.AddSubscribe(c, MailNotificationType.Ads);

m.AddSubscribe(c, MailNotificationType.News);

m.Notify(MailNotificationType.Ads);


