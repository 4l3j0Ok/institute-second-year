#!/bin/bash

# Directorio donde se encuentran los proyectos
CURRENT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"
SOURCE_DIR="../"

# Directorio 'public' en el proyecto Astro
PUBLIC_DIR="./public/projects"

projects_ignore=()
dot_projects_ignore_file="$CURRENT_DIR/.projectsignore"

# Leemos el .projectsignore si existe y llenamos el array projects_ignore
if [ -f "$dot_projects_ignore_file" ]; then
    while IFS= read -r line || [ -n "$line" ]; do
        # Eliminamos posibles caracteres de retorno de carro y solo agregamos líneas no vacías
        line=$(echo "$line" | tr -d '\r')
        if [ -n "$line" ]; then
            projects_ignore+=("$line")
        fi
    done < "$dot_projects_ignore_file"
else
    echo "No se encontró el archivo .projectsignore"
fi

echo "Proyectos a ignorar: ${projects_ignore[@]}"


rm -rf "$PUBLIC_DIR"
mkdir -p "$PUBLIC_DIR"

# Buscar recursivamente carpetas que contienen 'index.html' y copiarlas al directorio 'public'
find "$SOURCE_DIR" -type f -name 'index.html' | while read -r file; do
    project_dir=$(dirname "$file")
    relative_project_dir=$(realpath --relative-to="$SOURCE_DIR" "$project_dir")
    echo "Proyecto encontrado: $relative_project_dir"
    subject=$(basename "$(dirname "$project_dir")")
    ignore=false
    for ignore_pattern in "${projects_ignore[@]}"; do
        if [[ "$relative_project_dir" == "$ignore_pattern" || "$relative_project_dir" == $ignore_pattern/* ]]; then
            echo "Ignorado: $relative_project_dir"
            ignore=true
            break
        fi
    done

    if [ "$ignore" = true ]; then
        continue
    fi

    mkdir -p "$PUBLIC_DIR/$subject"
    project_name=$(basename "$project_dir")
    dest_dir="$PUBLIC_DIR/$subject/$project_name"
    cp -r "$project_dir" "$dest_dir"
    echo "Proyecto '$project_name' copiado a '$dest_dir'"
done

