#!/bin/sh

# Directorio donde se encuentran los proyectos
SOURCE_DIR="../"

# Directorio 'public' en el proyecto Astro
PUBLIC_DIR="./public/projects"

rm -rf "$PUBLIC_DIR"
mkdir -p "$PUBLIC_DIR"

# Buscar recursivamente carpetas que contienen 'index.html' y copiarlas al directorio 'public'
find "$SOURCE_DIR" -type f -name 'index.html' | while read -r file; do
    project_dir=$(dirname "$file")
    subject=$(basename "$(dirname "$project_dir")")
    mkdir -p "$PUBLIC_DIR/$subject"
    project_name=$(basename "$project_dir")
    dest_dir="$PUBLIC_DIR/$subject/$project_name"
    cp -r "$project_dir" "$dest_dir"
    echo "Proyecto '$project_name' copiado a '$dest_dir'"
done
