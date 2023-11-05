function isPalindrome(s: string): boolean {
    // Convert to lowercase and remove non-alphanumeric characters
    let cleaned = s.toLowerCase().replace(/[^a-z0-9]/g, "");

    // Check if the cleaned string is a palindrome
    let reversed = cleaned.split("").reverse().join("");
    return cleaned === reversed;
}
console.log(isPalindrome("A man, a plan, a canal: Panama"));  // Outputs: true
console.log(isPalindrome("race a car"));  // Outputs: false
console.log(isPalindrome(" "));  // Outputs: true
