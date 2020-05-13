using UnityEngine;
using System.Collections.Generic;

namespace SalusGames.Extentions
{
    public static class Extentions
    {
        /// <summary>
        /// Destroy's all the children
        /// </summary>
        /// <param name="transform">The parent transform</param>
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
        /// <param name="canvasGroup">The Canvas Group to hide</param>
        public static void Hide(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        /// <summary>
        /// Returns a random value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iList">The list to get a random value from</param>
        /// <returns></returns>
        public static T RandomValue<T>(this IList<T> iList)
        {
            int randomIndex = Random.Range(0, iList.Count);

            return iList[randomIndex];
        }

        /// <summary>
        /// Returns a random value and then removes it from the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iList">The list to get a random value from</param>
        /// <returns></returns>
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
        /// <param name="canvasGroup">The Canvas Group to show</param>
        public static void Show(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }

        /// <summary>
        /// Toggles the canvas group between showing and hiding
        /// </summary>
        /// <param name="canvasGroup">The Canvas Group to toggle</param>
        public static void Toggle(this CanvasGroup canvasGroup)
        {
            canvasGroup.alpha = (canvasGroup.alpha == 1f) ? 0f : 1f;
            canvasGroup.blocksRaycasts = !canvasGroup.blocksRaycasts;
            canvasGroup.interactable = !canvasGroup.interactable;
        }
    }
}