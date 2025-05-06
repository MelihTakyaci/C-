# 🐍🐬 Polymorphism Demo in C\#

A tiny project that shows **interface‑based** and **virtual/override** polymorphism in the simplest possible way – with dolphins and cobras!

![Class diagram](./docs/class_diagram.png)

> *“Different animals, same questions – different answers!”*

---

## 📦 Project Structure

```text
Polimorfizm/
 ├─ bin/Debug/net8.0/          # build outputs (git‑ignored)
 ├─ obj/                       # build metadata (git‑ignored)
 ├─ HintKralKobrasi.cs
 ├─ KralKobra.cs
 ├─ Yunus/
 │   ├─ CinNehirYunusu.cs
 │   └─ Yunus.cs
 ├─ IHayvan.cs
 ├─ Istemci.cs
 ├─ Program.cs
 ├─ Polimorfizm.csproj
 ├─ README.md
 └─ docs/
     ├─ class_diagram.png
     ├─ polymorphism_with_glossary.pdf
     ├─ polymorphism_final_aesthetic.pdf
     └─ polymorphism_for_kids.pdf
```

### 🙈 .gitignore Tip

Add `bin/`, `obj/`, and `*.pdf` to your `.gitignore` so compiled files and docs don't clutter commits.

```text
📂 PolymorphismDemo
 ├─ IHayvan.cs            # Interface – common questions
 ├─ Yunus.cs              # Base dolphin (virtual answers)
 ├─ CinNehirYunusu.cs     # Dolphin child – overrides answers
 ├─ KralKobra.cs          # Base snake (virtual venom answer)
 ├─ HintKralKobrasi.cs    # Snake child – overrides answers
 ├─ Istemci.cs            # Client prints info via interface
 ├─ Program.cs            # Entry point – chooses random animal
 └─ README.md             # You are here 👋
```

## ✨ What You Will Learn

| Concept          | Where to Look                             | TL;DR                                                 |
| ---------------- | ----------------------------------------- | ----------------------------------------------------- |
| **Interface**    | `IHayvan.cs`                              | List of questions every animal must answer            |
| **virtual**      | `Yunus.cs`, `KralKobra.cs`                | Parent says **“kids may change this”**                |
| **override**     | `CinNehirYunusu.cs`, `HintKralKobrasi.cs` | Child says **“I change it!”**                         |
| **Polymorphism** | `Istemci.cs` + `Program.cs`               | Client talks to interface – runtime decides who's who |

## 🚀 Running

```bash
# compile & run
$ dotnet run
```

You’ll see output similar to:

```
Hayvan Türü: Çin Nehir Yunusu
Soyu tükendi mi? True
Hayvan zehirli mi? Zehirsiz
```

Run it a few times – sometimes you get a cobra, sometimes a dolphin!

## 🖼️ Learning Resources

* **PDF Guide:** [`Polymorphism_for_kids.pdf`](./docs/Polymorphism_for_kids.pdf) – colourful, step‑by‑step explanation.
* **Aesthetic Guide:** [`Polymorphism_final_aesthetic.pdf`](./docs/Polymorphism_final_aesthetic.pdf)

## 📚 Glossary (quick remind)

* **Interface** – contract, no code.
* **virtual** – overridable default.
* **override** – customised answer.
* **Open/Closed Principle** – add new animals, no client change.
* **Runtime binding** – CLR picks the right method when the program runs.

## 🤝 Contributing

PRs welcome! Add a new animal class that implements `IHayvan` and override away – no client code should change.

## 📝 License

MIT. Do what you want, just keep the dolphins happy 🐬.
