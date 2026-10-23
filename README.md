# 🎯 Indovina il Numero

Un gioco da console in C# in cui devi indovinare un numero segreto compreso tra **1 e 100**, scegliendo tra quattro livelli di difficoltà.

Nato come progetto personale, pensato anche per essere un gioco semplice, chiaro e divertente da usare per chiunque, amici e persone con esigenze particolari comprese.

---

## 📋 Indice

- [Come si gioca](#-come-si-gioca)
- [Livelli di difficoltà](#-livelli-di-difficoltà)
- [Statistiche](#-statistiche)
- [Requisiti](#-requisiti)
- [Come avviare il gioco](#-come-avviare-il-gioco)
- [Struttura del progetto](#-struttura-del-progetto)
- [Cose da migliorare](#-cose-da-migliorare)
- [Contribuire](#-contribuire)

---

## 🎮 Come si gioca

1. Avvia il programma.
2. Scegli il livello digitando un numero da **1 a 4** e premi **Invio**.
3. Il gioco sceglie in segreto un numero tra 1 e 100.
4. Scrivi i tuoi tentativi, uno alla volta. Dopo ogni tentativo il gioco ti dice se hai indovinato oppure ti dà un aiuto.
5. Vinci se indovini il numero prima di finire i tentativi disponibili.
6. A fine partita puoi vedere le statistiche e decidere se rigiocare (rispondi `YES` o `NO`).

Esempio:

```text
╔═══════════════════════════════════════════════╗
║              INDOVINA IL NUMERO               ║
╠═══════════════════════════════════════════════╣
║  Scegli il livello con cui vuoi giocare       ║
║                                               ║
║  1) Livello Base    (max 50 tentativi)        ║
║  2) Livello Medio   (max 45 tentativi)        ║
║  3) Livello Avanzato (max 40 tentativi)       ║
║  4) Livello Superavanzato (max 30 tentativi)  ║
╚═══════════════════════════════════════════════╝

Scelta >>
```

---

## 🏆 Livelli di difficoltà

| Livello | Nome | Tentativi massimi | Aiuti |
|:-------:|------|:-----------------:|-------|
| 1 | Base | 50 | Indica la fascia in cui si trova il numero (dopo alcuni tentativi) e se sei vicino di ±5 |
| 2 | Medio | 45 | Indica se il numero è sopra o sotto il 50 e se sei vicino di ±10 |
| 3 | Avanzato | 40 | Indica se sei vicino di ±20 |
| 4 | Superavanzato | 30 | Nessun aiuto |

Se finisci i tentativi, il gioco ti rivela il numero che stavi cercando.

---

## 📊 Statistiche

Dopo ogni partita puoi vedere, per tutta la sessione di gioco:

- il numero di **partite giocate**;
- il numero di **vittorie**;
- quante volte hai **esaurito i tentativi**;
- la **media dei tentativi** usati per vincere.

Le statistiche si azzerano quando chiudi il programma.

---

## 🧰 Requisiti

- Windows
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework) o successivo (già incluso nelle versioni recenti di Windows 10 e 11)
- Per modificare il codice: [Visual Studio](https://visualstudio.microsoft.com/) (anche la versione gratuita **Community**) con il carico di lavoro *Sviluppo di applicazioni desktop .NET*

---

## ▶️ Come avviare il gioco

### Opzione 1: solo giocare

1. Vai nella sezione **Releases** di questo repository.
2. Scarica l'ultima versione (file `.zip`).
3. Estrai la cartella e fai doppio clic sul file `.exe`.

### Opzione 2: aprirlo con Visual Studio

```bash
git clone https://github.com/TUO-UTENTE/NOME-REPOSITORY.git
```

1. Apri il file `.sln` con Visual Studio.
2. Premi **F5** (oppure il pulsante verde ▶ **Avvia**).

---

## 🗂️ Struttura del progetto

```text
.
├── Program.cs     # tutto il gioco: menù, livelli, statistiche
├── README.md      # questo file
└── ...            # file di progetto generati da Visual Studio
```

---

## 🛠️ Cose da migliorare

Idee e miglioramenti previsti:

- [ ] Gestione degli input non numerici (oggi scrivere lettere al posto di un numero fa chiudere il programma).
- [ ] Aiuto di vicinanza più preciso (considerare la distanza reale dal numero segreto).
- [ ] Risposte `SI` / `NO` in italiano, oltre a `YES` / `NO`.
- [ ] Messaggi più incoraggianti durante la partita.
- [ ] Colori e testi più leggibili, per chi ha difficoltà visive.
- [ ] Meno testo da digitare, per chi ha difficoltà motorie.
- [ ] Riorganizzare il codice dei quattro livelli in un unico metodo, per evitare ripetizioni.
- [ ] Versione che funzioni anche su macOS e Linux (migrazione a .NET moderno).

---

## 🤝 Contribuire

I suggerimenti sono benvenuti, soprattutto se aiutano a rendere il gioco più accessibile.

1. Fai un *fork* del repository.
2. Crea un ramo per la tua modifica: `git checkout -b mia-modifica`.
3. Fai il *commit* delle modifiche e invia una *pull request*.

In alternativa, apri una **Issue** per segnalare un problema o proporre un'idea.

---

## 📄 Licenza

Da definire. Se vuoi che altri possano usare e modificare il gioco, aggiungi un file `LICENSE` (ad esempio la licenza MIT, che puoi scegliere direttamente da GitHub).
