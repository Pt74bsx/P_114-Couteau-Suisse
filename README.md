# 🔪 Couteau Suisse – Module 114

![Language](https://img.shields.io/badge/Langage-C%23-512BD4?logo=csharp)
![Project](https://img.shields.io/badge/Projet-Module%20114-blue)
![Status](https://img.shields.io/badge/Statut-En%20développement-orange)

## 📖 Présentation

Le **Couteau Suisse** est un projet réalisé dans le cadre du Module 114 – Codification, compression et chiffrement.

L'objectif est de développer une application console regroupant plusieurs outils informatiques liés aux notions abordées durant le module.

Cette première partie consiste à développer un outil de conversion entre le texte classique et le code Morse international.

## ✨ Fonctionnalités

### 1. Texte → Morse
- Conversion des lettres de A à Z.
- Conversion des chiffres de 0 à 9.
- Prise en charge des minuscules et des majuscules.
- Séparation des lettres par des espaces.
- Séparation des mots par `/`.
- Signalement des caractères non pris en charge.

### 2. Morse → Texte
- Conversion du code Morse en lettres.
- Conversion du code Morse en chiffres.
- Reconnaissance du séparateur `/` entre les mots.
- Gestion des codes Morse invalides.
- Vérification des caractères saisis.

### 3. Menu principal
- `1` : Texte vers Morse.
- `2` : Morse vers texte.
- `3` : À venir.
- `4` : À venir.
- `0` : Quitter.

## 🛠️ Technologies utilisées

- **Langage :** C#
- **Environnement :** Application console
- **IDE conseillé :** Visual Studio Code

## 🚀 Installation et lancement

1. Cloner le dépôt :

   ```bash
   git clone URL_DU_DEPOT
   ```

2. Accéder au dossier du projet :

   ```bash
   cd NOM_DU_PROJET
   ```

3. Lancer l'application :

   ```bash
   dotnet run
   ```

*Prérequis : disposer du SDK .NET compatible avec le projet.*

## 💡 Exemple d'utilisation

**Texte vers Morse**

```text
Entrée : SOS SOS

Sortie : ... --- ... / ... --- ...
```

**Morse vers texte**

```text
Entrée : ... --- ... / ... --- ...

Sortie : SOS SOS
```

## 📡 Table de correspondance Morse

| Lettre | Morse | Lettre | Morse |
|:---:|:---:|:---:|:---:|
| A | .- | N | -. |
| B | -... | O | --- |
| C | -.-. | P | .--. |
| D | -.. | Q | --.- |
| E | . | R | .-. |
| F | ..-. | S | ... |
| G | --. | T | - |
| H | .... | U | ..- |
| I | .. | V | ...- |
| J | .--- | W | .-- |
| K | -.- | X | -..- |
| L | .-.. | Y | -.-- |
| M | -- | Z | --.. |

## 🔮 Améliorations envisagées

- Ajout de la ponctuation.
- Lecture du Morse avec des signaux sonores.
- Export des conversions dans un fichier texte.
- Ajout de couleurs dans la console.
- Mode DEBUG pour afficher les conversions lettre par lettre.
- Mise en place de tests unitaires.

## 👨‍💻 Auteur

Projet réalisé dans le cadre du **Module 114 – ETML**.

---

*Première lame du Couteau Suisse : le code Morse.*
