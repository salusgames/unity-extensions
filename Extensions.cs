using UnityEngine;
using System.Collections.Generic;

namespace SalusGames.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Destroy's all the children
        /// </summary>
        public static void DestroyChildren(this Transform transform)
        {
            foreach (Transform child in transform)
            {
                Object.Destroy(child.gameObject);
            }
        }

        /// <summary>
        /// Hide's the canvas group
        /// </summary>
        public static void Hide(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        /// <summary>
        /// Returns a random color with alpha of 1
        /// </summary>
        public static void RandomColor(this Color color)
        {
            color.r = Random.Range(0f, 1f);
            color.g = Random.Range(0f, 1f);
            color.b = Random.Range(0f, 1f);
            color.a = 1;
        }

        /// <summary>
        /// Returns a random value
        /// </summary>
        public static T RandomValue<T>(this IList<T> iList)
        {
            int randomIndex = Random.Range(0, iList.Count);

            return iList[randomIndex];
        }

        /// <summary>
        /// Returns a random value and then removes it from the list
        /// </summary>
        public static T RandomValueAndRemove<T>(this IList<T> iList)
        {
            int randomIndex = Random.Range(0, iList.Count);
            T result = iList[randomIndex];
            iList.RemoveAt(randomIndex);

            return result;
        }

        /// <summary>
        /// Show's the canvas group
        /// </summary>
        public static void Show(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }

        /// <summary>
        /// Toggles the canvas group between showing and hiding
        /// </summary>
        public static void Toggle(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = (canvasGroup.alpha == 1f) ? 0f : 1f;
            canvasGroup.blocksRaycasts = !canvasGroup.blocksRaycasts;
            canvasGroup.interactable = !canvasGroup.interactable;
        }
    }
}