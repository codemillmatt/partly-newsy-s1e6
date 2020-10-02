Welcome back to Partly Cloudy! The show where you learn how to build a cloud-connected Xamarin mobile application. We start from nothing and don't quit until it's ready for the App Store!

# Episode 6 Recap - CollectionView All The Things!

In this episode we added the brand new `CollectionView` to our application. In our application the `CollectionView` takes the place of the `ListView` we were using to display the headline of each news article, and adds so, so, so much more.

## What's A CollectionView?

Well, first off, let me correct something that I said in the video that's no longer true...

> The CollectionView is no longer experimental!

In the video, I showed adding `global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");` to both the `AppDelegate.cs` and `MainActivity.cs` files.

You don't have to do that any longer! (If you have it in there, it doesn't hurt, but you don't have to do it.)

Ok ... so what's a `CollectionView`?

### It'll Make You Forget All About The ListView

The `CollectionView` picks up where the `ListView` left off in terms of functionality.

In addition to displaying data in a vertical list, the `CollectionView` can also display data in a horizontal list. Or even a grid. [Check out this article](https://docs.microsoft.com/xamarin/xamarin-forms/user-interface/collectionview/layout?WT.mc_id=partlycloudy-github-masoucou) for more information on that.

The `CollectionView` doesn't stop there though. It also allows you to [specify a view to display when there is no data](https://docs.microsoft.com/xamarin/xamarin-forms/user-interface/collectionview/emptyview?WT.mc_id=partlycloudy-github-masoucou). So now it's super simple to display **There's Nothing To See Here** when there is, in fact, nothing to see here, instead of an empty list.

And it's very easy to specify the empty view - just pop whatever you want to show up inside the `<CollectionView.EmptyView>` tags.

It'll look a little something like this.

```language-xaml
<CollectionView.EmptyView>
    <StackLayout HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand">
        <Label
            HorizontalOptions="CenterAndExpand"
            VerticalOptions="CenterAndExpand"
            HorizontalTextAlignment="Center"
            VerticalTextAlignment="Center"
            FontFamily="{StaticResource FabMDL2}"
            Text="&#xE900;"
            TextColor="Red"
            FontSize="64" />
    </StackLayout>
</CollectionView.EmptyView>
```

And of course that will be inside a `<CollectionView>` tag.

Not content to stop there, the `CollectionView` also supports [selecting multiple items at once](https://docs.microsoft.com/xamarin/xamarin-forms/user-interface/collectionview/selection?WT.mc_id=partlynewsys1e6-github-masoucou)!

I bet you've already forgotten about the `ListView` haven't you?

Those functionality areas are all fine and good - but the `CollectionView` keeps the same functionality that displays great looking data as well. And in this episode we handled that through individual `ContentView`s and `DataTemplateSelector`s with the `ItemTemplate`.

## Tell Me More About Those ItemTemplates

So, the `CollectionView` does not use cell's like the `ListView` does. It [relies on your providing your own `ContentView`s to display the data](https://docs.microsoft.com/xamarin/xamarin-forms/user-interface/collectionview/populate-data?WT.mc_id=partlycloudy-github-masoucou#define-item-appearance). And though this kind of sounds like a lot of work, it's not that far off from how the `ListView` works.

In this episode I skipped ahead and introduced a couple new views that displayed the news articles. `FeaturedImageArticleTile` and `HorizontalArticleTile`. Those are the views which get displayed in the `CollectionView`.

You can set the `ItemTemplate` of the `CollectionView` to a view - which will display the data that you want. In this episode though - I'm setting that `ItemTemplate` to a `DataTemplateSelector`.

The name of that `DataTemplateSelector` is `FrontPageArticleSelector`. [A `DataTemplateSelector`](https://docs.microsoft.com/xamarin/xamarin-forms/app-fundamentals/templates/data-templates/selector?WT.mc_id=partlycloudy-github-masoucou) selects which view to display based on the properties of the data the `CollectionView` is bound to.

And all that does is look at the incoming `Article` the `CollectionView` is bound to and check the `CurrentArticleCount` property. If the `CurrentArticleCount` is divisible by 4 - it returns the `FeaturedImageArticleTile`. Otherwise it returns the `HorizontalArticleTile`.

So what about those 2 views that are actually displaying the data?

If you take a look at the code, you'll see that they are just `ContentView`s that are expecting certain properties. `FeaturedImage`, `Category`, and `Headline` and `NewsProviderName`.

These properties happen to be the same names as the properties in the `Article` class. So all is good there - no additional mapping is needed.

So in order to make the data show up, within each class I'm creating custom bindable properties for each of those. That'll ensure they get bound to the user interface.

For the `FeaturedImage` property, the custom bindable looks like this:

```language-csharp
public static readonly BindableProperty FeaturedImageProperty = BindableProperty.Create(nameof(FeaturedImage), typeof(string), typeof(FeaturedImageArticleTile));

public string FeaturedImage
{
    get
    {
        return (string)GetValue(FeaturedImageProperty);
    }
    set
    {
        SetValue(FeaturedImageProperty, value);
    }
}
```

This way the `FeaturedImage` will be bound from the `Article` and then can be used in the XAML of the `FeaturedImageArticleTile`.

Take a peek at the code and let me know what you think!

## What's Next?

Next week we take a look at adding data with Azure Cosmos DB - but through a nice SDK that App Center has setup for us.