#!/bin/bash

# ------------------------------------------------
# Script de deploy para GitHub Pages (Blazor WASM)
# Autor: Caio Yuri Lopes
# ------------------------------------------------

set -e

PROJETO="Ibvc.UI"
REPO="https://github.com/caioyurilopes/Ibvc.git"
BRANCH="gh-pages"
BASE_PATH="/Ibvc/"

echo "📦 Publicando o projeto $PROJETO..."
dotnet publish $PROJETO -c Release

echo "🚚 Entrando na pasta de build..."
cd $PROJETO/bin/Release/net8.0/publish/wwwroot

echo "🧹 Limpando arquivos Git antigos..."
rm -rf .git

echo "🌿 Criando branch $BRANCH localmente..."
git init
git checkout -b $BRANCH
git remote add origin $REPO

echo "➕ Adicionando arquivos para commit..."
touch .nojekyll
git add .

echo "💬 Commitando alterações..."
git commit -m "🚀 Deploy automático para GitHub Pages"

echo "🚀 Enviando para o GitHub..."
git push origin $BRANCH --force

echo "✅ Deploy concluído com sucesso!"
echo "🌍 Acesse: https://caioyurilopes.github.io/Ibvc/"