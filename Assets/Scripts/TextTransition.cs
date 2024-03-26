using TMPro;
using UnityEngine;

public class TextTransition : MonoBehaviour
{
    public TMP_Text myText;
    public string targetText;
    public float fadeDuration = 1.5f; // Adjust as needed

    private bool transitioningToTarget = false;

    private void Start()
    {
        StartCoroutine(TransitionText());
    }

    private System.Collections.IEnumerator TransitionText()
    {
        while (true)
        {
            if (transitioningToTarget)
            {
                // Fade out the original text
                float elapsedTime = 0f;
                Color startColor = myText.color;
                Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 0f);

                while (elapsedTime < fadeDuration)
                {
                    elapsedTime += Time.deltaTime;
                    float t = Mathf.Clamp01(elapsedTime / fadeDuration);
                    myText.color = Color.Lerp(startColor, targetColor, t);
                    yield return null;
                }

                // Set the target text
                myText.text = targetText;
            }
            else
            {
                // Fade in the new text
                float elapsedTime = 0f;
                Color startColor = myText.color;
                Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 1f);

                while (elapsedTime < fadeDuration)
                {
                    elapsedTime += Time.deltaTime;
                    float t = Mathf.Clamp01(elapsedTime / fadeDuration);
                    myText.color = Color.Lerp(startColor, targetColor, t);
                    yield return null;
                }
            }

            // Toggle the transition direction
            transitioningToTarget = !transitioningToTarget;

            // Wait for a brief pause before transitioning again
            yield return new WaitForSeconds(1f); // Adjust the pause duration
        }
    }
}
