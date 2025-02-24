# Fehérje Feladat

Ez a projekt egy **feherje** nevű programot valósít meg, amely különböző műveleteket végez aminosav adatokkal és fehérjeszerkezetekkel. A program az **aminosav.txt** és **bsa.txt** fájlokat használja bemenetként.

---

## 📌 Feladatok

### 1️⃣ Aminosav adatok betöltése
✅ A program beolvassa az **aminosav.txt** fájl adatait.
✅ Ha a beolvasás sikertelen, az első öt aminosav adata állandóként van tárolva.

### 2️⃣ Relatív molekulatömeg kiszámítása
🔹 A program kiszámolja az aminosavak relatív molekulatömegét az alábbi atomtömegek alapján:
   - **Szén (C):** 12
   - **Hidrogén (H):** 1
   - **Oxigén (O):** 16
   - **Nitrogén (N):** 14
   - **Kén (S):** 32

### 3️⃣ Aminosavak rendezése molekulatömeg szerint
📌 A program növekvő sorrendbe állítja az aminosavakat relatív molekulatömegük szerint.
📌 Az eredményeket a képernyőre és az **eredmeny.txt** fájlba írja ki.

### 4️⃣ BSA fehérje összegképletének meghatározása
📌 A program beolvassa a **bsa.txt** fájlt és meghatározza az összegképletet.
📌 Figyelembe veszi, hogy a fehérjelánc összekapcsolódásakor vízmolekulák (H₂O) lépnek ki.

### 5️⃣ Fehérjelánc hasítása Kimotripszin enzimmel
🔬 A program meghatározza a Kimotripszin által széthasított leghosszabb láncdarabot.
🔬 Kiírja annak hosszát és az eredeti láncban elfoglalt helyét.

### 6️⃣ Fehérjelánc hasítása Factor XI enzimmel
🧬 A program ellenőrzi az Arginin (R) utáni hasítást, ha azt Alanin (A) vagy Valin (V) követi.
🧬 Megszámolja, hogy az így létrejött első fehérjelánc részletben hány Cisztein (C) található.

---

## 📂 Fájlok

| Fájlnév        | Leírás |
|---------------|--------|
| **Megoldas.cs** | A feladatok megvalósítását tartalmazza. |
| **Program.cs**  | A konzolos kimenetért felelős. |
| **Valtozo.cs**  | Az adatbeolvasást és tárolást végzi. |
| **aminosav.txt** | Az aminosavak adatait tartalmazza. |
| **bsa.txt**     | A BSA fehérje aminosav sorrendjét tartalmazza. |
| **eredmeny.txt** | Az eredményeket tartalmazó kimeneti fájl. |

---


## ⚙️ Fejlesztési információk

- **Nyelv:** C#
- **Futtatási környezet:** .NET
- **Szükséges fájlok:** aminosav.txt, bsa.txt

---

## 👨‍💻 Szerző

- **Készítette:** Kállai Gábor, Bánhidai Mátyás, Kapusi Gergő Levente, Nováki Tamás
- **Dátum:** 2025. február 24.

---

