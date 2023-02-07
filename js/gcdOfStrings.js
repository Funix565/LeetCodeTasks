/**
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
var gcdOfStrings = function(str1, str2) {
    if (str1.localeCompare(str2) == 0) {
        return str1;
    }
    
    let long = "";
    let short = "";

    if (str1.length >= str2.length) {
        long = str1;
        short = str2;
    }
    else {
        long = str2;
        short = str1;
    }

    // It looks like the Euclidean algorithm.
    // I glanced at this gif: https://commons.wikimedia.org/wiki/File:Euclidean_algorithm_252_105_animation_flipped.gif
    // It helped me develop this solution
    while (long.length > 0) {
        while (long.length >= short.length) {
            if (long.startsWith(short)) {
                long = long.slice(short.length);
            }
            else {
                return "";
            }
        }
        
        if (long.length == 0) {
            break;
        }
        
        if (long.length == 0) {
            break;
        }

        [long, short] = [short, long];
    }

    return short;
};
