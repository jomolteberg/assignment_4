using Assignment_4;
using Assignment_4.Classes;
using Assignment_4.Weapons;

// Creating weapons
Staff staff = new Staff();
Sword sword = new Sword();
Wand wand = new Wand();
Bow bow = new Bow();

// Creating characters
Sorcerer sorcerer = new Sorcerer("Graig", "The mighty firemage", staff);
Spellblade spellblade = new Spellblade("Elora", "The agile spellblade", sword);
Warlock warlock = new Warlock("Mordak", "The fearsome warlock", wand);
Warlock archerWarlock = new Warlock("Bane", "The sharpshooting warlock", bow);

// Displaying character attacks
sorcerer.Attack();
spellblade.Attack();
warlock.Attack();
archerWarlock.Attack();
