var specialConsole = (function () {
    function validatePlaceholders() {
        if (arguments[0] != arguments[1]) {
            throw new Error("Placeholders count and arguments count deffer.");
        }
    };

    return {
        writeLine: function () {
            if (arguments[1] == undefined) {
                return console.log(arguments[0]);
            } else {
                var format = arguments[0];
                var placeholders = format.match(/\{\d+\}/g);

                validatePlaceholders(placeholders.length, arguments.length - 1);

                for (var holder in placeholders) {
                    var replacementIndex = parseInt(placeholders[holder].substr(1, 1)) + 1;
                    var replacement = arguments[replacementIndex];
                    format = format.replace(placeholders[holder], replacement);
                }

                console.log(format);
            }
        },

        writeError: function () {
            this.writeLine.apply(null, arguments);
        },

        writeWarning: function () {
            this.writeLine.apply(null, arguments);
        },

        writeInfo: function () {
            this.writeLine.apply(null, arguments);
        }
    }
})();

try {
    specialConsole.writeLine("Message: hello");
    specialConsole.writeLine("Message: {0}", "hello");
    specialConsole.writeLine("Object: {0}", {name: "Gosho", toString: function () {return this.name}});
    specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
    specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
    specialConsole.writeInfo("Info: {0}", "Hi there! Here is some info for you.");
    specialConsole.writeError("Error object: {0}", { msg: "An error happened", toString: function() { return this.msg }});
} catch (e) {
    console.log(e.message);
}