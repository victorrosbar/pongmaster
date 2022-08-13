using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public PlayerPaddle playerPaddle;
    public ComputerPaddle computerPaddle;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        computerPaddle.ResetPosition();
        playerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }

    public void ComputerScores(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        computerPaddle.ResetPosition();
        playerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.AddStartingForce();
    }
}
