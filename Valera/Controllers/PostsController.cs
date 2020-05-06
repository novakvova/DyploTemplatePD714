using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Valera.Models;

namespace Valera.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PostsController : ControllerBase
    {
        public IActionResult Index()
        {
            List<PostItemModel> list = new List<PostItemModel>
            {
                new PostItemModel
                {
                    Id = 1,
                    Title = "Все свое: как 19-летняя Водонаева выглядела в бикини",
                    Image = "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/BB13CPmC.img?h=480&w=799&m=6&q=60&o=f&l=f&x=499&y=338",
                    Desctiption = "Алену Водонаеву пытаются заподозрить в пластике груди с того самого момента, как она попала в телевизор. Приводить доказательства в пользу натуральности форм звезда никогда не хотела. Она даже призналась в том, ...."
                },
                new PostItemModel
                {
                    Id = 2,
                    Title = "«Здравствуй, Алена»: как живет красотка-дочь солиста «На-На» Политова",
                    Image = "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/BB13GoHt.img?h=532&w=799&m=6&q=60&o=f&l=f&x=567&y=213",
                    Desctiption = "Говорят, природа «любит отыгрываться» на секс-символах, мол, чем красивее артист, тем более «обычные» у него дети. Не знаем, откуда взялась эта мысль, но пример Владимира Политова говорит об обратном!"
                }
            };
            //Thread.Sleep(2000);
            return Ok(list);
        }
    }
}