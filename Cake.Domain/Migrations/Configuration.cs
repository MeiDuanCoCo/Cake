using System.Data.Entity.Migrations;
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
        }
    }
}