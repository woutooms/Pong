using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore, _computerScore;

    public Ball ball;

    public Paddle playerPaddle, computerPaddel;

    public TextMeshProUGUI computerScoreText, playerScoreText;

    public void PlayerScores() {

        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        resetRound();

    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        resetRound();

    }

    private void resetRound() {

        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddel.ResetPosition();
    }




}
