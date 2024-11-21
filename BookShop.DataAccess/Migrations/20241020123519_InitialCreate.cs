using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d4d9835-a600-497f-9c19-86e2c84cc0ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4df07ad0-94c9-463a-bf32-c8870345aba5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("16ef7053-2d0c-44f7-878f-46e7b769aea6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c949c935-76b2-43cc-adfd-374c0cf1ac41"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("d3070373-bb9d-46e1-b629-ed0158f5eeda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c82bfe7-7851-4419-8821-c5602bc1f74e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6139cda9-a727-4127-a227-a56ce559c5af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("624db19e-36aa-4e19-b38c-d8bb688eb0ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62785823-8299-4664-aae7-9dbcca740e53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77a6acc7-4b50-4f56-b60a-11723f43f68e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3cc0b7f-7e01-4b1f-9112-1a04eacdef51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5348c3e-aaa6-494c-9be7-58e1be3be522"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca4d0993-58c6-4901-893f-4258099cee40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6e9d8b5-11ba-4a47-b7f3-e485b13efab9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3493), 1, "Scifi", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3543) },
                    { new Guid("c2f1140b-23b6-4d19-a54c-27a62a24258e"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3573), 2, "Action", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3575) },
                    { new Guid("e7422c17-36c5-4a26-b0ab-537d11167197"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3577), 3, "History", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3579) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("a2cbdc42-9819-493d-b6fe-2c34ce7f9597"), "Lala land", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3805), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3806) },
                    { new Guid("a6290276-2c43-4fa2-aca4-fa43c8b50d25"), "Tech City", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3778), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3782) },
                    { new Guid("f529086a-4800-4539-a3c6-55c98c580d0f"), "Vid City", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3790), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3792) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("61bc72e9-dd01-486e-945a-a4f62daaec6b"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3876), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3877) },
                    { new Guid("685d7208-1d80-4845-ad63-933319465eed"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3849), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3850) },
                    { new Guid("6e3bb5d8-bdba-4109-955a-70163567f2fd"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3871), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3872) },
                    { new Guid("913580bc-00cf-4a4f-aad6-a41c4ffb7f93"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3831), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3832) },
                    { new Guid("a1f290c8-a723-4713-98fd-d91dcef0cc29"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3844), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3846) },
                    { new Guid("a8f9cbb6-e5de-44ef-8fef-a09467b349bd"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3840), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3841) },
                    { new Guid("c8d917dc-ea7b-47c9-941b-f220ff946177"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3863), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3864) },
                    { new Guid("d6da1c62-e554-4462-96e7-58c8648dd93b"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3859), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3860) },
                    { new Guid("e74f34ae-4052-4bd4-b243-8b0bebfaae60"), "Corey, James S. A.", new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"), new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3854), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2024, 10, 20, 15, 35, 16, 683, DateTimeKind.Local).AddTicks(3855) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2f1140b-23b6-4d19-a54c-27a62a24258e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7422c17-36c5-4a26-b0ab-537d11167197"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a2cbdc42-9819-493d-b6fe-2c34ce7f9597"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a6290276-2c43-4fa2-aca4-fa43c8b50d25"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f529086a-4800-4539-a3c6-55c98c580d0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61bc72e9-dd01-486e-945a-a4f62daaec6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("685d7208-1d80-4845-ad63-933319465eed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6e3bb5d8-bdba-4109-955a-70163567f2fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("913580bc-00cf-4a4f-aad6-a41c4ffb7f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1f290c8-a723-4713-98fd-d91dcef0cc29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8f9cbb6-e5de-44ef-8fef-a09467b349bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8d917dc-ea7b-47c9-941b-f220ff946177"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6da1c62-e554-4462-96e7-58c8648dd93b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e74f34ae-4052-4bd4-b243-8b0bebfaae60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b0bfc8e-b240-48ea-abb4-92a9899f7546"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("0d4d9835-a600-497f-9c19-86e2c84cc0ce"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1745), 3, "History", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1746) },
                    { new Guid("4df07ad0-94c9-463a-bf32-c8870345aba5"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1742), 2, "Action", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1743) },
                    { new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1644), 1, "Scifi", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1659) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("16ef7053-2d0c-44f7-878f-46e7b769aea6"), "Lala land", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1988), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1989) },
                    { new Guid("c949c935-76b2-43cc-adfd-374c0cf1ac41"), "Tech City", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1973), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1974) },
                    { new Guid("d3070373-bb9d-46e1-b629-ed0158f5eeda"), "Vid City", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1983), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(1984) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("2c82bfe7-7851-4419-8821-c5602bc1f74e"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2058), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2058) },
                    { new Guid("6139cda9-a727-4127-a227-a56ce559c5af"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2052), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2053) },
                    { new Guid("624db19e-36aa-4e19-b38c-d8bb688eb0ad"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2027), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2028) },
                    { new Guid("62785823-8299-4664-aae7-9dbcca740e53"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2074), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2075) },
                    { new Guid("77a6acc7-4b50-4f56-b60a-11723f43f68e"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2063), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2064) },
                    { new Guid("a3cc0b7f-7e01-4b1f-9112-1a04eacdef51"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2042), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2043) },
                    { new Guid("b5348c3e-aaa6-494c-9be7-58e1be3be522"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2036), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2037) },
                    { new Guid("ca4d0993-58c6-4901-893f-4258099cee40"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2069), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2069) },
                    { new Guid("f6e9d8b5-11ba-4a47-b7f3-e485b13efab9"), "Corey, James S. A.", new Guid("b724b42e-81ca-4c9b-b4ed-1d871e6b5eee"), new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2079), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2024, 1, 14, 19, 16, 25, 531, DateTimeKind.Local).AddTicks(2080) }
                });
        }
    }
}
