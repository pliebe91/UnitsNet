#!/bin/bash
script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
set_version_script="$script_dir/set-version-UnitsNet.ps1"

names=(major minor patch suffix);
if [[ " "${names[@]}" " == *" "$1" "* ]] ;then
    powershell -NoProfile $set_version_script -bump $1
    exit 0
else
    echo "Usage: ./bump-version <major|minor|patch|suffix>"
    exit 1
fi