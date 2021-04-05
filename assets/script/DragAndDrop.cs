using System.IO.Enumeration;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Colleciontos;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

    public class DragAndDrop : MonoBehaviour, IPointerDownGandler,IBeginDragHadler,IEndDragHandler,IEndDragHandler
    {
    [SerializeField] private ReactTransform _transform;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private AudioSource _as;
    [SerializeField] private AudioClip _grab;
    [SerializeField] private AudioClip _drop;

    public void OnBeginDrag(PointerEventData eventData)
    {
        _as.clip = _grab;
        _as.Play();
        _canvasGroup.Alpha= 0.5f;
       _canvasGroup.bloacksRaycasts = false;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        _canvasGroup.Alpha = 1f;
        _canvasGroup.bloacksRaycasts = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        _transform.anchoredPosition += eventData.delta/_canvas.scaleFactor;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Apertou");
    }
}
