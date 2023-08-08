function colorize() {
    
    const allTableRow = Array.from(document.querySelectorAll('table tr:nth-child(even)'));

    for (const row of allTableRow) {
        row.style.backgroundColor = "Teal";
    }


}