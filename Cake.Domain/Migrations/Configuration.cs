using System.Data.Entity.Migrations;
using Cake.Domain.Cake;
using Cake.Domain.Link;

namespace Cake.Domain.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CakeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // �Զ�Ǩ��
            AutomaticMigrationDataLossAllowed = true; // ����������ݿ���ɾ������
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
                    Name = "��˾",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 2,
                    Name = "����",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 3,
                    Name = "�������˻�",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 4,
                    Name = "����",
                    Url = "/about",
                    Available = true
                },
                new QuickLink
                {
                    Id = 5,
                    Name = "��ϵ����",
                    Url = "/about",
                    Available = true
                });

            context.QuickLinkItems.AddOrUpdate(o => o.Id, new QuickLinkItem
                {
                    Id = 1,
                    Name = "��Ʒ",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 2,
                    Name = "�����﹤��",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 3,
                    Name = "�Ŷ�",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 4,
                    Name = "����",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 5,
                    Name = "�����̶�λ��",
                    Url = "/",
                    QuickLinkId = 1
                },
                new QuickLinkItem
                {
                    Id = 6,
                    Name = "֧��",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 7,
                    Name = "��������",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 8,
                    Name = "��֤",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 9,
                    Name = "��ϵ����",
                    Url = "/",
                    QuickLinkId = 2
                },
                new QuickLinkItem
                {
                    Id = 10,
                    Name = "����״̬",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 11,
                    Name = "��������",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 12,
                    Name = "�˻�����",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 13,
                    Name = "������Ʒ��",
                    Url = "/",
                    QuickLinkId = 3
                },
                new QuickLinkItem
                {
                    Id = 14,
                    Name = "��˽",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 15,
                    Name = "���������",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 16,
                    Name = "������θ�",
                    Url = "/",
                    QuickLinkId = 4
                },
                new QuickLinkItem
                {
                    Id = 17,
                    Name = "��Facebook�Ϲ�ע����",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 18,
                    Name = "��Twitter�Ϲ�ע����",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 19,
                    Name = "����������Google+",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 20,
                    Name = "��ע����Pinterest",
                    Url = "/",
                    QuickLinkId = 5
                },
                new QuickLinkItem
                {
                    Id = 21,
                    Name = "��Github�Ϲ�ע����",
                    Url = "/",
                    QuickLinkId = 5
                });

            
            context.CakeTypes.AddOrUpdate(o => o.Id, new CakeType
                {
                    Id = 1,
                    Name = "����ϵ",
                    Url = "/",
                    ParentId = 0,
                    Scenario = Scenario.Birthday | Scenario.Wedding | Scenario.Concession | Scenario.Store
                },
                new CakeType
                {
                    Id = 2,
                    Name = "ͨ����ζ",
                    Url = "/",
                    ParentId = 0,
                    Scenario = Scenario.Birthday | Scenario.Wedding | Scenario.Concession | Scenario.Store
                },
                new CakeType
                {
                    Id = 3,
                    Name = "������",
                    Url = "/",
                    ParentId = 0,
                    Scenario = Scenario.Birthday | Scenario.Wedding | Scenario.Concession
                },
                new CakeType
                {
                    Id = 4,
                    Name = "����",
                    Url = "/",
                    ParentId = 0,
                    Scenario = Scenario.Birthday | Scenario.Wedding | Scenario.Concession
                },
                new CakeType
                {
                    Id = 5,
                    Name = "�ؼ�",
                    Url = "/",
                    ParentId = 0,
                    Scenario = Scenario.Store
                },
                new CakeType
                {
                    Id = 6,
                    Name = "����",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 7,
                    Name = "����",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 8,
                    Name = "����",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 9,
                    Name = "���",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 10,
                    Name = "С��",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 11,
                    Name = "��ĸ",
                    Url = "/",
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 12,
                    Name = "�ɿ���",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 13,
                    Name = "���ˮ��",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 14,
                    Name = "����",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 15,
                    Name = "��ݮ",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 16,
                    Name = "���",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 17,
                    Name = "�޵���",
                    Url = "/",
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 18,
                    Name = "����",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 19,
                    Name = "��ͨ����",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 20,
                    Name = "2-3�㵰��",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 21,
                    Name = "������",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 22,
                    Name = "Բ��",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 23,
                    Name = "��Ƭ����",
                    Url = "/",
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 24,
                    Name = "1KG",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 25,
                    Name = "1.5KG",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 26,
                    Name = "2KG",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 27,
                    Name = "3KG",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 28,
                    Name = "4KG",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 29,
                    Name = "����",
                    Url = "/",
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 30,
                    Name = "�����走��",
                    Url = "/",
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 31,
                    Name = "��ʿ��",
                    Url = "/",
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 32,
                    Name = "Ruske����",
                    Url = "/",
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 33,
                    Name = "ֽ������",
                    Url = "/",
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 34,
                    Name = "�ɱ�",
                    Url = "/",
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 35,
                    Name = "Merveilleux",
                    Url = "/",
                    ParentId = 5
                });

            context.Cakes.AddOrUpdate(o => o.Id, new Cake.Cake
                {
                    Id = 1,
                    CakeName = "�ɿ���",
                    CaketypeId = 1,
                    ScenarioId = 1
                },
                new Cake.Cake
                {
                    Id = 2,
                    CakeName = "��ݮ",
                    CaketypeId = 2,
                    ScenarioId = 2
                });
        }
    }
}