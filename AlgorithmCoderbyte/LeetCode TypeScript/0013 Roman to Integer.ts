function romanToInt(s: string): number {
    let total: number = 0;

    let cur: number = getNumber(s.charAt(0));

    for (let i = 1; i < s.length; i++) {
        let next = getNumber(s.charAt(i));
        if (cur < next) {
            total -= cur;
        }
        else {
            total += cur;
        }
        cur = next;
    }

    total += cur;


    return total;



    function getNumber(s: string): number {
        switch (s) {
            case "I": return 1;
            case "V": return 5;
            case "X": return 10;
            case "L": return 50;
            case "C": return 100;
            case "D": return 500;
            case "M": return 1000;
            default: return 0;
        }
    }

};
console.log(romanToInt("IV"));