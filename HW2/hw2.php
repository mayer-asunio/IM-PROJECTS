<?php
echo "Enter row: ";
$rows = (int)trim(fgets(STDIN));

echo "Enter col: ";
$cols = (int)trim(fgets(STDIN));

$numbers = [];
$sum = 0;
$count = 0;

for ($i = 0; $i < $rows; $i++) {
    echo "Row " . ($i + 1) . PHP_EOL;
    for ($j = 0; $j < $cols; $j++) {
        echo "Enter number" . ($j + 1) . ": ";
        $num = (float)trim(fgets(STDIN));
        $numbers[$i][$j] = $num;
        $sum += $num;
        $count++;
    }
}

echo "\nThe numbers are:\n";
for ($i = 0; $i < $rows; $i++) {
    for ($j = 0; $j < $cols; $j++) {
        echo $numbers[$i][$j] . " ";
    }
    echo PHP_EOL;
}

$average = $sum / $count;

echo "\nSum: $sum ; Average: $average\n";