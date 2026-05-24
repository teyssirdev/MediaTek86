# MediaTek86

Application Windows Forms en C# permettant la gestion du personnel et des absences.

## Fonctionnalités

- Authentification
- Gestion du personnel
- Ajout d’un personnel
- Gestion des absences
- Ajout / modification / suppression d’absences

## Technologies utilisées

- C#
- Windows Forms
- MySQL
- Visual Studio 2026

## Auteur

Teyssir Essaadi – BTS SIO SLAM

## Architecture MVC

Le projet a été développé en utilisant l’architecture MVC (Modèle - Vue - Contrôleur).

- Modèle : contient les classes représentant les données.
- Vue : contient les formulaires Windows Forms.
- Contrôleur : gère les interactions entre les vues et la base de données.

Cette organisation permet d’avoir un code plus structuré et plus facile à maintenir.

## Base de données

L’application utilise une base de données MySQL nommée mediatek86.

Les principales tables utilisées sont :

- personnel
- absence
- motif
- responsable

Les mots de passe sont sécurisés avec SHA2.

## Installation

1. Importer le script SQL dans phpMyAdmin.
2. Ouvrir le projet dans Visual Studio 2026.
3. Vérifier la chaîne de connexion MySQL.
4. Lancer l’application.

## Documentation

Le dépôt contient :

- le script SQL complet ;
- la documentation technique ;
- la vidéo de démonstration ;
- les différentes sauvegardes GitHub du projet.

