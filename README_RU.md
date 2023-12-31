[English](README.md) | [Русский](README_RU.md)

<p align="center"><h1>⭐Занавес для Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/Unity-Curtain?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/Unity-Curtain?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/Unity-Curtain?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/Unity-Curtain/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/Unity-Curtain?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/Unity-Curtain?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/Unity-Curtain?style=flat">
  </a>
</p>



![image](https://github.com/RimuruDev/Unity-Curtain/assets/85500556/d72dde3a-34f5-4dd6-be83-a23961b0eeff)

## Обзор

Система Curtain в Unity — это надёжный и универсальный инструмент, разработанный для управления переходами и экранами
загрузки в ваших играх или приложениях. Она служит как 'занавес', скрывая изменения сцены или процессы загрузки,
происходящие в фоне, обеспечивая бесшовный игровой опыт.

## Зачем использовать Curtain?

Использование Curtain в ваших проектах Unity может значительно упростить управление переходами между сценами и
последовательностями загрузки. Она управляет отображением полноэкранного оверлея, который можно настроить и анимировать,
чтобы скрыть операции загрузки, которые могут отвлекать пользователя или нарушать игровой процесс.

## Функции

- **Анимированные переходы**: Curtain может плавно появляться и исчезать с настраиваемыми анимациями.
- **Поддержка коллбэков**: Выполнение любой логики после анимации с помощью коллбэков, идеально подходит для загрузки
  сцен или ресурсов в фоне.
- **Настройка внешнего вида**: Легко измените внешний вид вашего занавеса через ScriptableObject Unity, чтобы
  соответствовать эстетике вашей игры.
- **Контроль задержки**: Укажите задержки для скрытия занавеса, что позволит гибко синхронизировать его с процессами
  загрузки вашей игры.

## Установка  << (Устарело!)

1. Клонируйте репозиторий или загрузите последний релиз.
2. Импортируйте пакет Curtain в ваш проект Unity.
3. Перетащите префаб `CurtainView` на ваш холст в нужной сцене.

## Использование

Сначала убедитесь, что в вашей сцене есть экземпляр `CurtainView`, и что `CurtainService` правильно инициализирован и
внедрён там, где вы хотите управлять занавесом.

### Показ занавеса

Вызовите `curtainService.ShowCurtain()`, чтобы закрыть экран. Это обычно делается перед началом операции загрузки.

```csharp
curtainService.ShowCurtain(isAnimated: true, callback: () =>
{
    // Этот блок кода выполнится после полного появления занавеса.
    // Здесь вы можете начать загрузку вашей сцены или ресурсов.
});
```

## Скрытие занавеса

Как только операция загрузки будет завершена, вызовите curtainService.HideCurtain(), чтобы убрать занавес и показать
обновленное содержимое.

```csharp
curtainService.HideCurtain(isAnimated: true, callback: () =>
{
    // Этот код выполнится после полного исчезновения занавеса.
    // Это идеальное место для перехода на новую сцену или выполнения других послезагрузочных операций.
});
```

## Задержка скрытия

Если вам нужно оставить занавес отображаемым в течение установленного времени (например, чтобы показать анимацию
загрузки или экран брендинга), вы можете использовать функцию задержки скрытия.

```csharp
// Предполагая, что у вас есть объект curtainConfig с свойством HideDelay
curtainService.HideCurtain(curtainConfig.HideDelay, () =>
{
    // Код для выполнения после задержки и скрытия занавеса.
});
```

## Зависимости:

- NaughtyAttributes: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996), [GitHub](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996)
- DoTween: [Asset Store](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)
- Zenject: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735), [GitHub](https://github.com/modesttree/Zenject)

## Участие

Ваши предложения приветствуются! Если у вас есть какие-либо предложения по улучшению этого инструмента, пожалуйста, не
стесняйтесь делать форк репозитория, вносить свои изменения и отправлять запрос на слияние (pull request).

## Лицензия

Этот проект лицензирован под лицензией MIT - см. файл LICENSE для подробностей.

### Разработано RimuruDev
