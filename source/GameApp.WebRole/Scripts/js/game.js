$(document).ready(function () {
    var gameId = $.query.get('game');
    var game = new Game();
    game.load(gameId);
});

var selectedPiece;

var Game = function () {
}

Game.prototype = {
    gamePeices: [],
    
    load: function (gameId) {
        this.gamePeices.push('4');
        this.gamePeices.push('98');
        this.gamePeices.push('1201700386');
        this.gamePeices.push('1063140540');
        this.gamePeices.push('1435451815');
        this.gamePeices.push('1332833126');
        this.gamePeices.push('14903120');
        this.gamePeices.push('515673069');
        this.gamePeices.push('14812017');
        this.gamePeices.push('97');
        this.gamePeices.push('5');
        this.gamePeices.push('6');
        this.gamePeices.push('7');
        this.gamePeices.push('51');
        this.gamePeices.push('50');

        this.populateGamePeicesUI();
        this.addUIEventsToPieces();
        this.setupGuessModal();
    },

    populateGamePeicesUI: function () {
        for (var i = 0; i < this.gamePeices.length; i++) {
            $('#gamepieces').append('<li data-piece="' + this.gamePeices[i] + '"><img src="http://graph.facebook.com/' + this.gamePeices[i] + '/picture?type=large" />' +
                                        '<div class="bottom-button">' +
                                            '<button class="btn guess">Guess</button>' +
                                        '</div>' +
                                    '</li>');
        }
    },

    addUIEventsToPieces: function () {
        var self = this;
        $('#gamepieces img').click(self.hidePiece);
        $('#gamepieces .guess').click(self.guessPiece);
    },

    hidePiece: function () {
        $(this).attr('src', '/Images/hiddenuser.png');
    },

    guessPiece: function () {
        selectedPiece = $(this).parent().parent().attr('data-piece');
        $('#guessModal').modal('show');
    },

    setupGuessModal: function () {
        $('#guessModal').modal();
        $('#guessModal').modal('hide');
        $('#guess-modal-button').click(function () {
            alert('You have guessed user: ' + selectedPiece);
        });
        $('#cancel-modal-button').click(function () {
            $('#guessModal').modal('hide');
        });
    },
};

