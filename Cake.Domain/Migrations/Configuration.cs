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

            context.Scenarios.AddOrUpdate(o => o.Id, new Scenario
                {
                    Id = 1,
                    ScenarioName = "����"
                },
                new Scenario
                {
                    Id = 2,
                    ScenarioName = "����"
                },
                new Scenario
                {
                    Id = 3,
                    ScenarioName = "�ر��Ż�"
                },
                new Scenario
                {
                    Id = 4,
                    ScenarioName = "�̵�"
                });

            context.CakeTypes.AddOrUpdate(o => o.Id, new CakeType
                {
                    Id = 1,
                    Name = "����ϵ",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 2,
                    Name = "ͨ����ζ",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 3,
                    Name = "������",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 4,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 5,
                    Name = "�ؼ�",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Title,
                    ParentId = 0
                },
                new CakeType
                {
                    Id = 6,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 7,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 8,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 9,
                    Name = "���",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 10,
                    Name = "С��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 11,
                    Name = "��ĸ",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 1
                },
                new CakeType
                {
                    Id = 12,
                    Name = "�ɿ���",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 13,
                    Name = "���ˮ��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 14,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 15,
                    Name = "��ݮ",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 16,
                    Name = "���",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 17,
                    Name = "�޵���",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 2
                },
                new CakeType
                {
                    Id = 18,
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 19,
                    Name = "��ͨ����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 20,
                    Name = "2-3�㵰��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 21,
                    Name = "������",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 22,
                    Name = "Բ��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 3
                },
                new CakeType
                {
                    Id = 23,
                    Name = "��Ƭ����",
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
                    Name = "����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 4
                },
                new CakeType
                {
                    Id = 29,
                    Name = "�����走��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 30,
                    Name = "��ʿ��",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 31,
                    Name = "Ruske����",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 32,
                    Name = "ֽ������",
                    Url = "/",
                    CakeTypeEnum = CakeTypeEnum.Content,
                    ParentId = 5
                },
                new CakeType
                {
                    Id = 33,
                    Name = "�ɱ�",
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