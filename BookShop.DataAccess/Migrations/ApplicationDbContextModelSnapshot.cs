﻿// <auto-generated />
using System;
using BookShop.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3493),
                            DisplayOrder = 1,
                            Name = "Scifi",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3543)
                        },
                        new
                        {
                            Id = new Guid("c2f1140b-23b6-4d19-a54c-27a62a24258e"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3573),
                            DisplayOrder = 2,
                            Name = "Action",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3575)
                        },
                        new
                        {
                            Id = new Guid("e7422c17-36c5-4a26-b0ab-537d11167197"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3577),
                            DisplayOrder = 3,
                            Name = "History",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3579)
                        });
                });

            modelBuilder.Entity("BookShop.Models.Company", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6290276-2c43-4fa2-aca4-fa43c8b50d25"),
                            City = "Tech City",
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3778),
                            Name = "Tech Solution",
                            PhoneNumber = "6669990000",
                            PostalCode = "12121",
                            State = "IL",
                            StreetAddress = "123 Tech St",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3782)
                        },
                        new
                        {
                            Id = new Guid("f529086a-4800-4539-a3c6-55c98c580d0f"),
                            City = "Vid City",
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3790),
                            Name = "Vivid Books",
                            PhoneNumber = "7779990000",
                            PostalCode = "66666",
                            State = "IL",
                            StreetAddress = "999 Vid St",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3792)
                        },
                        new
                        {
                            Id = new Guid("a2cbdc42-9819-493d-b6fe-2c34ce7f9597"),
                            City = "Lala land",
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3805),
                            Name = "Readers Club",
                            PhoneNumber = "1113335555",
                            PostalCode = "99999",
                            State = "NY",
                            StreetAddress = "999 Main St",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3806)
                        });
                });

            modelBuilder.Entity("BookShop.Models.Product", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("913580bc-00cf-4a4f-aad6-a41c4ffb7f93"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3831),
                            Description = "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>",
                            ISBN = "978-0-316-12908-4",
                            ImageUrl = "\\images\\product\\LeviathanWakes.jpg",
                            ListPrice = 300000.0,
                            Price = 290000.0,
                            Price100 = 260000.0,
                            Price50 = 280000.0,
                            Title = "Leviathan Wakes",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3832)
                        },
                        new
                        {
                            Id = new Guid("a8f9cbb6-e5de-44ef-8fef-a09467b349bd"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3840),
                            Description = "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>",
                            ISBN = "978-0-316-12906-0",
                            ImageUrl = "\\images\\product\\CalibansWar.jpg",
                            ListPrice = 310000.0,
                            Price = 295000.0,
                            Price100 = 265000.0,
                            Price50 = 285000.0,
                            Title = "Caliban's War",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3841)
                        },
                        new
                        {
                            Id = new Guid("a1f290c8-a723-4713-98fd-d91dcef0cc29"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3844),
                            Description = "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>",
                            ISBN = "978-0-316-12907-7",
                            ImageUrl = "\\images\\product\\AbaddonsGate.jpg",
                            ListPrice = 320000.0,
                            Price = 300000.0,
                            Price100 = 275000.0,
                            Price50 = 290000.0,
                            Title = "Abaddon's Gate",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3846)
                        },
                        new
                        {
                            Id = new Guid("685d7208-1d80-4845-ad63-933319465eed"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3849),
                            Description = "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>",
                            ISBN = "978-0-316-21762-0",
                            ImageUrl = "\\images\\product\\CibolaBurn.jpg",
                            ListPrice = 270000.0,
                            Price = 260000.0,
                            Price100 = 240000.0,
                            Price50 = 250000.0,
                            Title = "Cibola Burn",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3850)
                        },
                        new
                        {
                            Id = new Guid("e74f34ae-4052-4bd4-b243-8b0bebfaae60"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3854),
                            Description = "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>",
                            ISBN = "978-0-316-21758-3",
                            ImageUrl = "\\images\\product\\NemesisGames.jpg",
                            ListPrice = 300000.0,
                            Price = 290000.0,
                            Price100 = 260000.0,
                            Price50 = 280000.0,
                            Title = "Nemesis Games",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3855)
                        },
                        new
                        {
                            Id = new Guid("d6da1c62-e554-4462-96e7-58c8648dd93b"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3859),
                            Description = "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>",
                            ISBN = "978-0-316-33474-7",
                            ImageUrl = "\\images\\product\\BabylonsAshes.jpg",
                            ListPrice = 320000.0,
                            Price = 300000.0,
                            Price100 = 275000.0,
                            Price50 = 290000.0,
                            Title = "Babylon's Ashes",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3860)
                        },
                        new
                        {
                            Id = new Guid("c8d917dc-ea7b-47c9-941b-f220ff946177"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3863),
                            Description = "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>",
                            ISBN = "978-0-316-33283-5",
                            ImageUrl = "\\images\\product\\PersepolisRising.jpg",
                            ListPrice = 300000.0,
                            Price = 290000.0,
                            Price100 = 260000.0,
                            Price50 = 280000.0,
                            Title = "Persepolis Rising	",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3864)
                        },
                        new
                        {
                            Id = new Guid("6e3bb5d8-bdba-4109-955a-70163567f2fd"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3871),
                            Description = "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>",
                            ISBN = "978-0-316-33286-6",
                            ImageUrl = "\\images\\product\\TiamatsWrath.jpg",
                            ListPrice = 320000.0,
                            Price = 300000.0,
                            Price100 = 275000.0,
                            Price50 = 290000.0,
                            Title = "Tiamat's Wrath",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3872)
                        },
                        new
                        {
                            Id = new Guid("61bc72e9-dd01-486e-945a-a4f62daaec6b"),
                            Author = "Corey, James S. A.",
                            CategoryId = new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"),
                            Created = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3876),
                            Description = "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>",
                            ISBN = "978-0-316-33291-0",
                            ImageUrl = "\\images\\product\\LeviathanFalls.jpg",
                            ListPrice = 330000.0,
                            Price = 320000.0,
                            Price100 = 300000.0,
                            Price50 = 310000.0,
                            Title = "Leviathan Falls",
                            Updated = new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3877)
                        });
                });

            modelBuilder.Entity("BookShop.Models.ShoppingCart", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookShop.Models.ApplicationUser", b =>
                {
                    b.HasOne("BookShop.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("BookShop.Models.Product", b =>
                {
                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShop.Models.ShoppingCart", b =>
                {
                    b.HasOne("BookShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
