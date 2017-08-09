using System.Data.Entity.Migrations;
using Cake.Domain.Cake;
using Cake.Domain.Link;

namespace Cake.Domain.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CakeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // 自动迁移
            AutomaticMigrationDataLossAllowed = true; // 允许更新数据库是删除数据
        }

        protected override void Seed(CakeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.QuickLinks.AddOrUpdate(o => o.Id, new QuickLink
                {
                    Id = 1,
                    Name = "公司",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 2,
                    Name = "服务",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 3,
                    Name = "订单和退货",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 4,
                    Name = "法律",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 5,
                    Name = "联系我们",
                    Url = "/about",
                    Available = true
                });

            context.QuickLinkItems.AddOrUpdate(o => o.Id, new QuickLinkItem
                {
                    Id = 1,
                    Name = "制品",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 2,
                    Name = "在这里工作",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 3,
                    Name = "团队",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 4,
                    Name = "精彩",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 5,
                    Name = "经销商定位器",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 6,
                    Name = "支持",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 7,
                    Name = "常问问题",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 8,
                    Name = "保证",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 9,
                    Name = "联系我们",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 10,
                    Name = "订单状态",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 11,
                    Name = "运输政策",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 12,
                    Name = "退货政策",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 13,
                    Name = "数字礼品卡",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 14,
                    Name = "隐私",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 15,
                    Name = "条款和条件",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 16,
                    Name = "社会责任感",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 17,
                    Name = "在Facebook上关注我们",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 18,
                    Name = "在Twitter上关注我们",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 19,
                    Name = "跟随我们在Google+",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 20,
                    Name = "关注我们Pinterest",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 21,
                    Name = "在Github上关注我们",
                    Url = "/",
                    QuickLinkId = 5
                });

            context.Scenarios.AddOrUpdate(o => o.Id, new Scenario
                {
                    Id = 1,
                    ScenarioName = "生日"
                },
                new Scenario
                {
                    Id = 2,
                    ScenarioName = "婚礼"
                },
                new Scenario
                {
                    Id = 3,
                    ScenarioName = "特别优惠"
                },
                new Scenario
                {
                    Id = 4,
                    ScenarioName = "商店"
                });

            context.CakeTypes.AddOrUpdate(o => o.Id, new CakeType
                {
                    Id = 1,
                    Name = "按关系",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 2,
                    Name = "通过风味",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 3,
                    Name = "按主题",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 4,
                    Name = "重量",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 5,
                    Name = "特价",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 6,
                    Name = "朋友",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 7,
                    Name = "情人",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 8,
                    Name = "妹妹",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 9,
                    Name = "哥哥",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 10,
                    Name = "小孩",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 11,
                    Name = "父母",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 12,
                    Name = "巧克力",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 13,
                    Name = "混合水果",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 14,
                    Name = "奶油",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 15,
                    Name = "草莓",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 16,
                    Name = "香草",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 17,
                    Name = "无蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 18,
                    Name = "心形",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 19,
                    Name = "卡通蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 20,
                    Name = "2-3层蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 21,
                    Name = "正方形",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 22,
                    Name = "圆形",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 23,
                    Name = "照片蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 24,
                    Name = "1KG",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 25,
                    Name = "1.5KG",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 24,
                    Name = "2KG",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 26,
                    Name = "3KG",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 27,
                    Name = "4KG",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 28,
                    Name = "更重",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 29,
                    Name = "冰激凌蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 30,
                    Name = "瑞士卷",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 31,
                    Name = "Ruske康培",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 32,
                    Name = "纸杯蛋糕",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 33,
                    Name = "松饼",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 34,
                    Name = "Merveilleux",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                });

            context.Cakes.AddOrUpdate(o => o.Id, new Cake.Cake
                {
                    Id = 1,
                    CakeName = "巧克力",
                    CaketypeId = 1,
                    ScenarioId = 1
                },
                new Cake.Cake
                {
                    Id = 2,
                    CakeName = "草莓",
                    CaketypeId = 2,
                    ScenarioId = 2
                });
        }
    }
}