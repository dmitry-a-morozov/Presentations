



<!DOCTYPE html>
<html lang="en" class="   ">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>Documents/vizlib--show.fsx at cbf82299e144bcca3a4b19a99cd67a9c139ccb51 · tpetricek/Documents</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="tpetricek/Documents" name="twitter:title" /><meta content="Documents - Includes samples for my blog posts, source code and slides for my talks and other resources." name="twitter:description" /><meta content="https://avatars3.githubusercontent.com/u/485413?v=2&amp;s=400" name="twitter:image:src" />
<meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars3.githubusercontent.com/u/485413?v=2&amp;s=400" property="og:image" /><meta content="tpetricek/Documents" property="og:title" /><meta content="https://github.com/tpetricek/Documents" property="og:url" /><meta content="Documents - Includes samples for my blog posts, source code and slides for my talks and other resources." property="og:description" />

    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="conduit-xhr" href="https://ghconduit.com:25035">
    <link rel="xhr-socket" href="/_sockets">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="62712B92:0875:2B87FEFB:53FCD777" name="octolytics-dimension-request_id" /><meta content="3004037" name="octolytics-actor-id" /><meta content="dmitry-a-morozov" name="octolytics-actor-login" /><meta content="30d7447fe1ffa279b3c51d911821e3ca8dce2cb4a1357642a176422fdac5e45f" name="octolytics-actor-hash" />
    

    
    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="ibvuWSeiCFlqdVudTgzHjYYgL2mTnqrc3N5EIMe3Lji3Jc+cR8xEhQNAmSols/2bdXEugvlQDLbEf6eAa9YwZA==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-097e3a01c37cee1b559eba68515b4477a84f8e04.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://assets-cdn.github.com/assets/github2-41e9a0027746729d5f906aa2b9f7fce786fb0a14.css" media="all" rel="stylesheet" type="text/css" />
    


    <meta http-equiv="x-pjax-version" content="70991f568a341ac97bcdbc6d16a1e3fa">

      
  <meta name="description" content="Documents - Includes samples for my blog posts, source code and slides for my talks and other resources.">
  <meta name="go-import" content="github.com/tpetricek/Documents git https://github.com/tpetricek/Documents.git">

  <meta content="485413" name="octolytics-dimension-user_id" /><meta content="tpetricek" name="octolytics-dimension-user_login" /><meta content="1124021" name="octolytics-dimension-repository_id" /><meta content="tpetricek/Documents" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="1124021" name="octolytics-dimension-repository_network_root_id" /><meta content="tpetricek/Documents" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/tpetricek/Documents/commits/cbf82299e144bcca3a4b19a99cd67a9c139ccb51.atom" rel="alternate" title="Recent Commits to Documents:cbf82299e144bcca3a4b19a99cd67a9c139ccb51" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      
      


      <div class="header header-logged-in true">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" aria-label="Homepage" ga-data-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search">
          <form accept-charset="UTF-8" action="/tpetricek/Documents/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/tpetricek/Documents/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>
      <ul class="header-nav left">
        <li class="header-nav-item explore" data-ga-click="Header, go to explore, text:explore">
          <a class="header-nav-link" href="/explore">Explore</a>
        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
          </li>
        <li class="header-nav-item">
          <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
        </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/dmitry-a-morozov" data-ga-click="Header, go to profile, text:username">
      <img alt="Dmitry Morozov" class="avatar" data-user="3004037" height="20" src="https://avatars2.githubusercontent.com/u/3004037?v=2&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">dmitry-a-morozov</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      
<ul class="dropdown-menu">
  <li>
    <a href="/new"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="dropdown-divider"></li>
    <li class="dropdown-header">
      <span title="tpetricek/Documents">This repository</span>
    </li>
      <li>
        <a href="/tpetricek/Documents/issues/new"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
</ul>

    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="lkiTPm+wfZ1GcATP8eLXRoVJL1H2kJgf6fZMHioiu4pYBWr4tmbFRvN1LFvnv3AGijzdcBY/JJqujg6rW8DfbQ==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>


    
  </div>
</div>

      

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="b+OZO6TN13LKxxOLufWtsMShZFgYWBSp8en8Cv9cfsOiopzFUIl/J9mQ+6uFHz33fEP9ol5/AaZpnWgtOi+mOQ==" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="1124021" />

    <div class="select-menu js-menu-container js-select-menu">
      <a class="social-count js-social-count" href="/tpetricek/Documents/watchers">
        16
      </a>
      <a href="/tpetricek/Documents/subscription"
        class="minibutton select-menu-button with-count js-menu-target" role="button" tabindex="0" aria-haspopup="true">
        <span class="js-select-button">
          <span class="octicon octicon-eye"></span>
          Watch
        </span>
      </a>

      <div class="select-menu-modal-holder">
        <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
          <div class="select-menu-header">
            <span class="select-menu-title">Notifications</span>
            <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container" role="menu">

            <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">Be notified when participating or @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">Be notified of all conversations.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">Never be notified.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/tpetricek/Documents/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="x8BAojBTuOcU8qAdF2u2b+LBLLNnJe9NWW7A+HQvWUIPqzEfjHvKQkOwzU8sAeq6Qiq4HHlLrmkG6MgR12l9Cw==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Unstar this repository" title="Unstar tpetricek/Documents">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/tpetricek/Documents/stargazers">
          59
        </a>
</form>
    <form accept-charset="UTF-8" action="/tpetricek/Documents/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="VwGSI7EbNXRTUGShn3Y0mdpBy3kyd49txHVSpT9uE16sST+n+vZsrVrEsSddLeQ0NH+SW3j4eyi6cuTbXbuO5Q==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Star this repository" title="Star tpetricek/Documents">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/tpetricek/Documents/stargazers">
          59
        </a>
</form>  </div>

  </li>


        <li>
          <a href="/tpetricek/Documents/fork" class="minibutton with-count js-toggler-target fork-button tooltipped-n" title="Fork your own copy of tpetricek/Documents to your account" aria-label="Fork your own copy of tpetricek/Documents to your account" rel="facebox nofollow">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/tpetricek/Documents/network" class="social-count">24</a>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/tpetricek" class="url fn" itemprop="url" rel="author"><span itemprop="title">tpetricek</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/tpetricek/Documents" class="js-current-repository js-repo-home-link">Documents</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<div class="sunken-menu vertical-right repo-nav js-repo-nav js-repository-container-pjax js-octicon-loaders" data-issue-count-url="/tpetricek/Documents/issues/counts">
  <div class="sunken-menu-contents">
    <ul class="sunken-menu-group">
      <li class="tooltipped tooltipped-w" aria-label="Code">
        <a href="/tpetricek/Documents" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-pjax="true" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /tpetricek/Documents">
          <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

        <li class="tooltipped tooltipped-w" aria-label="Issues">
          <a href="/tpetricek/Documents/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /tpetricek/Documents/issues">
            <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
            <span class="js-issue-replace-counter"></span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>

      <li class="tooltipped tooltipped-w" aria-label="Pull Requests">
        <a href="/tpetricek/Documents/pulls" aria-label="Pull Requests" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g p" data-selected-links="repo_pulls /tpetricek/Documents/pulls">
            <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull Requests</span>
            <span class="js-pull-replace-counter"></span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>


        <li class="tooltipped tooltipped-w" aria-label="Wiki">
          <a href="/tpetricek/Documents/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g w" data-selected-links="repo_wiki /tpetricek/Documents/wiki">
            <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>
    </ul>
    <div class="sunken-menu-separator"></div>
    <ul class="sunken-menu-group">

      <li class="tooltipped tooltipped-w" aria-label="Pulse">
        <a href="/tpetricek/Documents/pulse/weekly" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="pulse /tpetricek/Documents/pulse/weekly">
          <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

      <li class="tooltipped tooltipped-w" aria-label="Graphs">
        <a href="/tpetricek/Documents/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_graphs repo_contributors /tpetricek/Documents/graphs">
          <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
    </ul>


  </div>
</div>

              <div class="only-with-full-nav">
                
  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/tpetricek/Documents.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/tpetricek/Documents.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="git@github.com:tpetricek/Documents.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="git@github.com:tpetricek/Documents.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/tpetricek/Documents" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/tpetricek/Documents" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>


<p class="clone-options">You can clone with
      <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>,
      <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>,
      or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/tpetricek/Documents" class="minibutton sidebar-button" title="Save tpetricek/Documents to your computer and use it in GitHub Desktop." aria-label="Save tpetricek/Documents to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/tpetricek/Documents/archive/cbf82299e144bcca3a4b19a99cd67a9c139ccb51.zip"
                   class="minibutton sidebar-button"
                   aria-label="Download tpetricek/Documents as a zip file"
                   title="Download tpetricek/Documents as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/tpetricek/Documents/blob/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries/vizlib--show.fsx" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:f9fd7e66a5aaadc3f88b39db9b995801 -->

<div class="file-navigation">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="minibutton select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref=""
    title=""
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>tree:</i>
    <span class="js-select-button css-truncate-target">cbf82299e1</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div> <!-- /.select-menu-header -->

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div><!-- /.select-menu-tabs -->
      </div><!-- /.select-menu-filters -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item ">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/tpetricek/Documents/blob/master/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries/vizlib--show.fsx"
                 data-name="master"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="master">master</a>
            </div> <!-- /.select-menu-item -->
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

    </div> <!-- /.select-menu-modal -->
  </div> <!-- /.select-menu-modal-holder -->
</div> <!-- /.select-menu -->

  <div class="button-group right">
    <a href="/tpetricek/Documents/find/cbf82299e144bcca3a4b19a99cd67a9c139ccb51"
          class="js-show-file-finder minibutton empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button class="js-zeroclipboard minibutton zeroclipboard-button"
          data-clipboard-text="Talks 2013/F# Type Providers Tutorial/queries/vizlib--show.fsx"
          aria-label="Copy to clipboard"
          data-copied-hint="Copied!">
      <span class="octicon octicon-clippy"></span>
    </button>
  </div>

  <div class="breadcrumb">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/tpetricek/Documents/tree/cbf82299e144bcca3a4b19a99cd67a9c139ccb51" class="" data-branch="cbf82299e144bcca3a4b19a99cd67a9c139ccb51" data-direction="back" data-pjax="true" itemscope="url" rel="nofollow"><span itemprop="title">Documents</span></a></span></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/tpetricek/Documents/tree/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013" class="" data-branch="cbf82299e144bcca3a4b19a99cd67a9c139ccb51" data-direction="back" data-pjax="true" itemscope="url" rel="nofollow"><span itemprop="title">Talks 2013</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/tpetricek/Documents/tree/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial" class="" data-branch="cbf82299e144bcca3a4b19a99cd67a9c139ccb51" data-direction="back" data-pjax="true" itemscope="url" rel="nofollow"><span itemprop="title">F# Type Providers Tutorial</span></a></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/tpetricek/Documents/tree/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries" class="" data-branch="cbf82299e144bcca3a4b19a99cd67a9c139ccb51" data-direction="back" data-pjax="true" itemscope="url" rel="nofollow"><span itemprop="title">queries</span></a></span><span class="separator"> / </span><strong class="final-path">vizlib--show.fsx</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="Tomas Petricek" class="avatar" data-user="485413" height="24" src="https://avatars1.githubusercontent.com/u/485413?v=2&amp;s=48" width="24" />
        <span class="author"><a href="/tpetricek" rel="author">tpetricek</a></span>
        <time datetime="2013-05-30T18:39:46+01:00" is="relative-time">May 30, 2013</time>
        <div class="commit-title">
            <a href="/tpetricek/Documents/commit/06aeb8ae7dbbf93b41a1fbc34f916cfdd2a96c69" class="message" data-pjax="true" title="Adding F# type providers tutorial">Adding F# type providers tutorial</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>1</strong>
           contributor
        </a>
      </p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="Tomas Petricek" data-user="485413" height="24" src="https://avatars1.githubusercontent.com/u/485413?v=2&amp;s=48" width="24" />
            <a href="/tpetricek">tpetricek</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file-box">
  <div class="file">
    <div class="meta clearfix">
      <div class="info file-name">
          <span>150 lines (128 sloc)</span>
          <span class="meta-divider"></span>
        <span>6.357 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
          <a href="/tpetricek/Documents/raw/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries/vizlib--show.fsx" class="minibutton " id="raw-url">Raw</a>
            <a href="/tpetricek/Documents/blame/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries/vizlib--show.fsx" class="minibutton js-update-url-with-hash">Blame</a>
          <a href="/tpetricek/Documents/commits/cbf82299e144bcca3a4b19a99cd67a9c139ccb51/Talks%202013/F%23%20Type%20Providers%20Tutorial/queries/vizlib--show.fsx" class="minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->


            <a class="octicon-button disabled tooltipped tooltipped-w" href="#"
               aria-label="You must be on a branch to make or propose changes to this file"><span class="octicon octicon-pencil"></span></a>

          <a class="octicon-button danger disabled tooltipped tooltipped-w" href="#"
             aria-label="You must be on a branch to make or propose changes to this file">
          <span class="octicon octicon-trashcan"></span>
        </a>
      </div><!-- /.actions -->
    </div>
      
  <div class="blob-wrapper data type-f">
      <table class="highlight tab-size-8 js-file-line-container">
      <tr>
        <td id="L1" class="blob-num js-line-number" data-line-number="1"></td>
        <td id="LC1" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L2" class="blob-num js-line-number" data-line-number="2"></td>
        <td id="LC2" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L3" class="blob-num js-line-number" data-line-number="3"></td>
        <td id="LC3" class="blob-code js-file-line"><span class="o">[&lt;</span><span class="n">AutoOpen</span><span class="o">&gt;]</span></td>
      </tr>
      <tr>
        <td id="L4" class="blob-num js-line-number" data-line-number="4"></td>
        <td id="LC4" class="blob-code js-file-line"><span class="k">module</span> <span class="nn">ShowWpf</span></td>
      </tr>
      <tr>
        <td id="L5" class="blob-num js-line-number" data-line-number="5"></td>
        <td id="LC5" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L6" class="blob-num js-line-number" data-line-number="6"></td>
        <td id="LC6" class="blob-code js-file-line"><span class="o">#</span><span class="n">load</span> <span class="s">&quot;vizlib--load-wpf.fsx&quot;</span></td>
      </tr>
      <tr>
        <td id="L7" class="blob-num js-line-number" data-line-number="7"></td>
        <td id="LC7" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L8" class="blob-num js-line-number" data-line-number="8"></td>
        <td id="LC8" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Reflection</span></td>
      </tr>
      <tr>
        <td id="L9" class="blob-num js-line-number" data-line-number="9"></td>
        <td id="LC9" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.ComponentModel</span></td>
      </tr>
      <tr>
        <td id="L10" class="blob-num js-line-number" data-line-number="10"></td>
        <td id="LC10" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System</span></td>
      </tr>
      <tr>
        <td id="L11" class="blob-num js-line-number" data-line-number="11"></td>
        <td id="LC11" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows</span></td>
      </tr>
      <tr>
        <td id="L12" class="blob-num js-line-number" data-line-number="12"></td>
        <td id="LC12" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Input</span></td>
      </tr>
      <tr>
        <td id="L13" class="blob-num js-line-number" data-line-number="13"></td>
        <td id="LC13" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Controls</span></td>
      </tr>
      <tr>
        <td id="L14" class="blob-num js-line-number" data-line-number="14"></td>
        <td id="LC14" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Data</span></td>
      </tr>
      <tr>
        <td id="L15" class="blob-num js-line-number" data-line-number="15"></td>
        <td id="LC15" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Media</span></td>
      </tr>
      <tr>
        <td id="L16" class="blob-num js-line-number" data-line-number="16"></td>
        <td id="LC16" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Media.Imaging</span></td>
      </tr>
      <tr>
        <td id="L17" class="blob-num js-line-number" data-line-number="17"></td>
        <td id="LC17" class="blob-code js-file-line"><span class="k">open</span> <span class="nn">System.Windows.Documents</span></td>
      </tr>
      <tr>
        <td id="L18" class="blob-num js-line-number" data-line-number="18"></td>
        <td id="LC18" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L19" class="blob-num js-line-number" data-line-number="19"></td>
        <td id="LC19" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">quotes</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L20" class="blob-num js-line-number" data-line-number="20"></td>
        <td id="LC20" class="blob-code js-file-line">    <span class="o">[|</span> <span class="s">&quot;F# - The Language For Big, Big Data!&quot;</span><span class="o">;</span> </td>
      </tr>
      <tr>
        <td id="L21" class="blob-num js-line-number" data-line-number="21"></td>
        <td id="LC21" class="blob-code js-file-line">       <span class="s">&quot;Learn about F# at www.fsharp.net&quot;</span><span class="o">;</span> </td>
      </tr>
      <tr>
        <td id="L22" class="blob-num js-line-number" data-line-number="22"></td>
        <td id="LC22" class="blob-code js-file-line">       <span class="s">&quot;F# - Simple Code for Complex Problems&quot;</span> <span class="o">|]</span></td>
      </tr>
      <tr>
        <td id="L23" class="blob-num js-line-number" data-line-number="23"></td>
        <td id="LC23" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L24" class="blob-num js-line-number" data-line-number="24"></td>
        <td id="LC24" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">quote</span> <span class="o">=</span> <span class="n">quotes</span><span class="o">.[</span><span class="n">Random</span><span class="o">(</span><span class="nn">DateTime</span><span class="p">.</span><span class="nn">Now</span><span class="p">.</span><span class="n">Second</span><span class="o">).</span><span class="n">Next</span><span class="o">(</span><span class="n">quotes</span><span class="o">.</span><span class="n">Length</span><span class="o">)]</span> </td>
      </tr>
      <tr>
        <td id="L25" class="blob-num js-line-number" data-line-number="25"></td>
        <td id="LC25" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L26" class="blob-num js-line-number" data-line-number="26"></td>
        <td id="LC26" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L27" class="blob-num js-line-number" data-line-number="27"></td>
        <td id="LC27" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">win</span> <span class="o">=</span> <span class="n">Window</span><span class="o">(</span><span class="n">Title</span><span class="o">=</span><span class="s">&quot;Data Grid&quot;</span><span class="o">,</span> <span class="n">Content</span><span class="o">=</span><span class="n">quote</span><span class="o">,</span> <span class="n">Topmost</span><span class="o">=</span><span class="k">true</span><span class="o">,</span> <span class="n">Height</span><span class="o">=</span><span class="mi">500</span><span class="o">.</span><span class="mi">0</span><span class="o">,</span> <span class="n">Width</span><span class="o">=</span><span class="mi">500</span><span class="o">.</span><span class="mi">0</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L28" class="blob-num js-line-number" data-line-number="28"></td>
        <td id="LC28" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">WindowStartupLocation</span> <span class="o">&lt;-</span> <span class="nn">WindowStartupLocation</span><span class="p">.</span><span class="n">Manual</span></td>
      </tr>
      <tr>
        <td id="L29" class="blob-num js-line-number" data-line-number="29"></td>
        <td id="LC29" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">Left</span> <span class="o">&lt;-</span> <span class="mi">700</span><span class="o">.</span><span class="mi">0</span></td>
      </tr>
      <tr>
        <td id="L30" class="blob-num js-line-number" data-line-number="30"></td>
        <td id="LC30" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">Top</span> <span class="o">&lt;-</span> <span class="mi">50</span><span class="o">.</span><span class="mi">0</span></td>
      </tr>
      <tr>
        <td id="L31" class="blob-num js-line-number" data-line-number="31"></td>
        <td id="LC31" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">Show</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L32" class="blob-num js-line-number" data-line-number="32"></td>
        <td id="LC32" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L33" class="blob-num js-line-number" data-line-number="33"></td>
        <td id="LC33" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">FontSize</span> <span class="o">&lt;-</span> <span class="mi">22</span><span class="o">.</span><span class="mi">0</span></td>
      </tr>
      <tr>
        <td id="L34" class="blob-num js-line-number" data-line-number="34"></td>
        <td id="LC34" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">FontFamily</span> <span class="o">&lt;-</span> <span class="n">FontFamily</span> <span class="s">&quot;Calibri&quot;</span></td>
      </tr>
      <tr>
        <td id="L35" class="blob-num js-line-number" data-line-number="35"></td>
        <td id="LC35" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">FontWeight</span> <span class="o">&lt;-</span> <span class="nn">FontWeights</span><span class="p">.</span><span class="n">Bold</span></td>
      </tr>
      <tr>
        <td id="L36" class="blob-num js-line-number" data-line-number="36"></td>
        <td id="LC36" class="blob-code js-file-line"><span class="n">win</span><span class="o">.</span><span class="n">Foreground</span> <span class="o">&lt;-</span> <span class="nn">Brushes</span><span class="p">.</span><span class="n">DarkBlue</span></td>
      </tr>
      <tr>
        <td id="L37" class="blob-num js-line-number" data-line-number="37"></td>
        <td id="LC37" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L38" class="blob-num js-line-number" data-line-number="38"></td>
        <td id="LC38" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">mutable</span> <span class="n">ct</span> <span class="o">=</span> <span class="k">new</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Threading</span><span class="p">.</span><span class="n">CancellationTokenSource</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L39" class="blob-num js-line-number" data-line-number="39"></td>
        <td id="LC39" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">cancelPrevious</span><span class="bp">()</span> <span class="o">=</span> <span class="n">ct</span><span class="o">.</span><span class="n">Cancel</span><span class="bp">()</span><span class="o">;</span> <span class="n">ct</span> <span class="o">&lt;-</span> <span class="k">new</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Threading</span><span class="p">.</span><span class="n">CancellationTokenSource</span><span class="bp">()</span><span class="o">;</span> <span class="n">ct</span><span class="o">.</span><span class="n">Token</span></td>
      </tr>
      <tr>
        <td id="L40" class="blob-num js-line-number" data-line-number="40"></td>
        <td id="LC40" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L41" class="blob-num js-line-number" data-line-number="41"></td>
        <td id="LC41" class="blob-code js-file-line"><span class="k">module</span> <span class="nn">Seq</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L42" class="blob-num js-line-number" data-line-number="42"></td>
        <td id="LC42" class="blob-code js-file-line">    <span class="k">let</span> <span class="nv">toObservableCollection</span> <span class="o">(</span><span class="n">ct</span><span class="o">:</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Threading</span><span class="p">.</span><span class="n">CancellationToken</span><span class="o">)</span> <span class="o">(</span><span class="n">s</span><span class="o">:</span><span class="n">seq</span><span class="o">&lt;</span><span class="k">&#39;</span><span class="n">T</span><span class="o">&gt;)</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L43" class="blob-num js-line-number" data-line-number="43"></td>
        <td id="LC43" class="blob-code js-file-line">        <span class="k">let</span> <span class="nv">ctxt</span> <span class="o">=</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Threading</span><span class="p">.</span><span class="nn">SynchronizationContext</span><span class="p">.</span><span class="n">Current</span></td>
      </tr>
      <tr>
        <td id="L44" class="blob-num js-line-number" data-line-number="44"></td>
        <td id="LC44" class="blob-code js-file-line">        <span class="k">if</span> <span class="n">ctxt</span> <span class="o">=</span> <span class="k">null</span> <span class="k">then</span> <span class="n">invalidOp</span> <span class="s">&quot;This function may only be called from a thread where SynchronizationContext.Current is not null&quot;</span></td>
      </tr>
      <tr>
        <td id="L45" class="blob-num js-line-number" data-line-number="45"></td>
        <td id="LC45" class="blob-code js-file-line">        <span class="k">let</span> <span class="nv">oc</span> <span class="o">=</span> <span class="k">new</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Collections</span><span class="p">.</span><span class="nn">ObjectModel</span><span class="p">.</span><span class="n">ObservableCollection</span><span class="o">&lt;</span><span class="k">&#39;</span><span class="n">T</span><span class="o">&gt;</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L46" class="blob-num js-line-number" data-line-number="46"></td>
        <td id="LC46" class="blob-code js-file-line">        <span class="k">let</span> <span class="nv">work</span> <span class="o">=</span> <span class="n">async</span> <span class="o">{</span> <span class="k">for</span> <span class="n">x</span> <span class="k">in</span> <span class="n">s</span> <span class="k">do</span> <span class="n">ctxt</span><span class="o">.</span><span class="n">Post</span><span class="o">((</span><span class="k">fun</span> <span class="o">_</span> <span class="o">-&gt;</span> <span class="n">oc</span><span class="o">.</span><span class="n">Add</span> <span class="n">x</span><span class="o">),</span><span class="k">null</span><span class="o">)</span> <span class="o">}</span> </td>
      </tr>
      <tr>
        <td id="L47" class="blob-num js-line-number" data-line-number="47"></td>
        <td id="LC47" class="blob-code js-file-line">        <span class="nn">Async</span><span class="p">.</span><span class="n">Start</span><span class="o">(</span><span class="n">work</span><span class="o">,</span><span class="n">ct</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L48" class="blob-num js-line-number" data-line-number="48"></td>
        <td id="LC48" class="blob-code js-file-line">        <span class="n">oc</span></td>
      </tr>
      <tr>
        <td id="L49" class="blob-num js-line-number" data-line-number="49"></td>
        <td id="LC49" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L50" class="blob-num js-line-number" data-line-number="50"></td>
        <td id="LC50" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">propsOfObj</span> <span class="o">(</span><span class="n">sampleObj</span><span class="o">:</span><span class="kt">obj</span><span class="o">)</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L51" class="blob-num js-line-number" data-line-number="51"></td>
        <td id="LC51" class="blob-code js-file-line">    <span class="o">[</span> <span class="k">match</span> <span class="n">sampleObj</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L52" class="blob-num js-line-number" data-line-number="52"></td>
        <td id="LC52" class="blob-code js-file-line">      <span class="o">|</span> <span class="o">:?</span> <span class="kt">string</span> <span class="o">|</span> <span class="o">:?</span> <span class="n">int</span> <span class="o">|</span> <span class="o">:?</span> <span class="kt">double</span>  <span class="o">|</span> <span class="o">:?</span> <span class="kt">single</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L53" class="blob-num js-line-number" data-line-number="53"></td>
        <td id="LC53" class="blob-code js-file-line">         <span class="k">yield</span> <span class="s">&quot;&quot;</span><span class="o">,</span> <span class="n">sampleObj</span><span class="o">.</span><span class="n">GetType</span><span class="bp">()</span><span class="o">,</span> <span class="n">id</span></td>
      </tr>
      <tr>
        <td id="L54" class="blob-num js-line-number" data-line-number="54"></td>
        <td id="LC54" class="blob-code js-file-line">      <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L55" class="blob-num js-line-number" data-line-number="55"></td>
        <td id="LC55" class="blob-code js-file-line">      <span class="k">match</span> <span class="n">sampleObj</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L56" class="blob-num js-line-number" data-line-number="56"></td>
        <td id="LC56" class="blob-code js-file-line">      <span class="o">|</span> <span class="o">:?</span> <span class="nn">System</span><span class="p">.</span><span class="nn">ComponentModel</span><span class="p">.</span><span class="n">ICustomTypeDescriptor</span> <span class="k">as</span> <span class="n">t</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L57" class="blob-num js-line-number" data-line-number="57"></td>
        <td id="LC57" class="blob-code js-file-line">          <span class="k">for</span> <span class="n">p</span> <span class="k">in</span> <span class="n">t</span><span class="o">.</span><span class="n">GetProperties</span><span class="bp">()</span>  <span class="k">do</span> </td>
      </tr>
      <tr>
        <td id="L58" class="blob-num js-line-number" data-line-number="58"></td>
        <td id="LC58" class="blob-code js-file-line">              <span class="k">yield</span> <span class="n">p</span><span class="o">.</span><span class="n">Name</span><span class="o">,</span> <span class="n">p</span><span class="o">.</span><span class="n">PropertyType</span><span class="o">,</span> <span class="n">p</span><span class="o">.</span><span class="n">GetValue</span></td>
      </tr>
      <tr>
        <td id="L59" class="blob-num js-line-number" data-line-number="59"></td>
        <td id="LC59" class="blob-code js-file-line">      <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> <span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L60" class="blob-num js-line-number" data-line-number="60"></td>
        <td id="LC60" class="blob-code js-file-line">      <span class="k">for</span> <span class="n">p</span> <span class="k">in</span> <span class="n">sampleObj</span><span class="o">.</span><span class="n">GetType</span><span class="bp">()</span><span class="o">.</span><span class="n">GetProperties</span><span class="bp">()</span> <span class="k">do</span> </td>
      </tr>
      <tr>
        <td id="L61" class="blob-num js-line-number" data-line-number="61"></td>
        <td id="LC61" class="blob-code js-file-line">          <span class="k">if</span> <span class="n">p</span><span class="o">.</span><span class="n">GetIndexParameters</span><span class="bp">()</span><span class="o">.</span><span class="n">Length</span> <span class="o">=</span> <span class="mi">0</span> <span class="k">then</span> </td>
      </tr>
      <tr>
        <td id="L62" class="blob-num js-line-number" data-line-number="62"></td>
        <td id="LC62" class="blob-code js-file-line">              <span class="k">yield</span> <span class="n">p</span><span class="o">.</span><span class="n">Name</span><span class="o">,</span> <span class="n">p</span><span class="o">.</span><span class="n">PropertyType</span><span class="o">,</span> <span class="o">(</span><span class="k">fun</span> <span class="kt">obj</span> <span class="o">-&gt;</span> <span class="n">p</span><span class="o">.</span><span class="n">GetValue</span><span class="o">(</span><span class="kt">obj</span><span class="o">,</span><span class="k">null</span><span class="o">))</span> <span class="o">]</span></td>
      </tr>
      <tr>
        <td id="L63" class="blob-num js-line-number" data-line-number="63"></td>
        <td id="LC63" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L64" class="blob-num js-line-number" data-line-number="64"></td>
        <td id="LC64" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">convertPropertyOfObjToText</span> <span class="o">(</span><span class="n">propValue</span><span class="o">:</span><span class="kt">obj</span><span class="o">)</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L65" class="blob-num js-line-number" data-line-number="65"></td>
        <td id="LC65" class="blob-code js-file-line">    <span class="k">match</span> <span class="n">propValue</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L66" class="blob-num js-line-number" data-line-number="66"></td>
        <td id="LC66" class="blob-code js-file-line">    <span class="o">|</span> <span class="k">null</span> <span class="o">-&gt;</span> <span class="s">&quot;&quot;</span></td>
      </tr>
      <tr>
        <td id="L67" class="blob-num js-line-number" data-line-number="67"></td>
        <td id="LC67" class="blob-code js-file-line">    <span class="o">|</span> <span class="o">:?</span> <span class="n">seq</span><span class="o">&lt;</span><span class="kt">string</span><span class="o">&gt;</span> <span class="k">as</span> <span class="n">s</span> <span class="o">-&gt;</span> <span class="n">s</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">toList</span> <span class="o">|&gt;</span> <span class="kt">string</span></td>
      </tr>
      <tr>
        <td id="L68" class="blob-num js-line-number" data-line-number="68"></td>
        <td id="LC68" class="blob-code js-file-line">    <span class="o">|</span> <span class="o">:?</span> <span class="nn">System</span><span class="p">.</span><span class="n">String</span> <span class="k">as</span> <span class="n">s</span> <span class="o">-&gt;</span> <span class="n">s</span></td>
      </tr>
      <tr>
        <td id="L69" class="blob-num js-line-number" data-line-number="69"></td>
        <td id="LC69" class="blob-code js-file-line">    <span class="o">|</span> <span class="o">:?</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Collections</span><span class="p">.</span><span class="n">IEnumerable</span> <span class="k">as</span> <span class="n">e</span> <span class="o">-&gt;</span> <span class="s">&quot;...&quot;</span></td>
      </tr>
      <tr>
        <td id="L70" class="blob-num js-line-number" data-line-number="70"></td>
        <td id="LC70" class="blob-code js-file-line"><span class="c">(*</span></td>
      </tr>
      <tr>
        <td id="L71" class="blob-num js-line-number" data-line-number="71"></td>
        <td id="LC71" class="blob-code js-file-line"><span class="c">        let e = Seq.cast&lt;obj&gt; e |&gt; Seq.toList</span></td>
      </tr>
      <tr>
        <td id="L72" class="blob-num js-line-number" data-line-number="72"></td>
        <td id="LC72" class="blob-code js-file-line"><span class="c">        match e with </span></td>
      </tr>
      <tr>
        <td id="L73" class="blob-num js-line-number" data-line-number="73"></td>
        <td id="LC73" class="blob-code js-file-line"><span class="c">        | [] -&gt; </span><span class="s">&quot;&quot;</span><span class="c"></span></td>
      </tr>
      <tr>
        <td id="L74" class="blob-num js-line-number" data-line-number="74"></td>
        <td id="LC74" class="blob-code js-file-line"><span class="c">        | _ -&gt; sprintf </span><span class="s">&quot;%60A&quot;</span><span class="c"> e</span></td>
      </tr>
      <tr>
        <td id="L75" class="blob-num js-line-number" data-line-number="75"></td>
        <td id="LC75" class="blob-code js-file-line"><span class="c">*)</span></td>
      </tr>
      <tr>
        <td id="L76" class="blob-num js-line-number" data-line-number="76"></td>
        <td id="LC76" class="blob-code js-file-line">    <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L77" class="blob-num js-line-number" data-line-number="77"></td>
        <td id="LC77" class="blob-code js-file-line">        <span class="k">let</span> <span class="nv">text</span> <span class="o">=</span> <span class="n">sprintf</span> <span class="s">&quot;%60A&quot;</span> <span class="n">propValue</span></td>
      </tr>
      <tr>
        <td id="L78" class="blob-num js-line-number" data-line-number="78"></td>
        <td id="LC78" class="blob-code js-file-line">        <span class="c1">// TODO: find out why this is coming through</span></td>
      </tr>
      <tr>
        <td id="L79" class="blob-num js-line-number" data-line-number="79"></td>
        <td id="LC79" class="blob-code js-file-line">        <span class="k">if</span> <span class="n">text</span><span class="o">.</span><span class="n">Contains</span> <span class="s">&quot;{DataGrid.NewItem&quot;</span> <span class="k">then</span> <span class="s">&quot;&quot;</span> <span class="k">else</span></td>
      </tr>
      <tr>
        <td id="L80" class="blob-num js-line-number" data-line-number="80"></td>
        <td id="LC80" class="blob-code js-file-line">        <span class="n">text</span></td>
      </tr>
      <tr>
        <td id="L81" class="blob-num js-line-number" data-line-number="81"></td>
        <td id="LC81" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L82" class="blob-num js-line-number" data-line-number="82"></td>
        <td id="LC82" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">probeObj</span> <span class="o">(</span><span class="kt">obj</span><span class="o">:</span><span class="kt">obj</span><span class="o">)</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L83" class="blob-num js-line-number" data-line-number="83"></td>
        <td id="LC83" class="blob-code js-file-line">    <span class="n">propsOfObj</span> <span class="kt">obj</span> <span class="o">|&gt;</span> <span class="nn">List</span><span class="p">.</span><span class="n">iter</span> <span class="o">(</span><span class="k">fun</span> <span class="o">(_,_,</span><span class="n">getter</span><span class="o">)</span> <span class="o">-&gt;</span> <span class="k">try</span> <span class="n">getter</span> <span class="kt">obj</span> <span class="o">|&gt;</span> <span class="n">convertPropertyOfObjToText</span> <span class="o">|&gt;</span> <span class="n">ignore</span> <span class="k">with</span> <span class="o">_</span> <span class="o">-&gt;</span> <span class="bp">()</span><span class="o">)</span> </td>
      </tr>
      <tr>
        <td id="L84" class="blob-num js-line-number" data-line-number="84"></td>
        <td id="LC84" class="blob-code js-file-line">    <span class="kt">obj</span></td>
      </tr>
      <tr>
        <td id="L85" class="blob-num js-line-number" data-line-number="85"></td>
        <td id="LC85" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L86" class="blob-num js-line-number" data-line-number="86"></td>
        <td id="LC86" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">showGrid</span> <span class="o">(</span><span class="kt">obj</span><span class="o">:</span> <span class="kt">obj</span><span class="o">)</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L87" class="blob-num js-line-number" data-line-number="87"></td>
        <td id="LC87" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L88" class="blob-num js-line-number" data-line-number="88"></td>
        <td id="LC88" class="blob-code js-file-line">    <span class="n">win</span><span class="o">.</span><span class="n">Content</span> <span class="o">&lt;-</span> </td>
      </tr>
      <tr>
        <td id="L89" class="blob-num js-line-number" data-line-number="89"></td>
        <td id="LC89" class="blob-code js-file-line">        <span class="k">match</span> <span class="kt">obj</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L90" class="blob-num js-line-number" data-line-number="90"></td>
        <td id="LC90" class="blob-code js-file-line">        <span class="o">|</span> <span class="o">:?</span> <span class="kt">string</span> <span class="o">-&gt;</span> <span class="kt">obj</span></td>
      </tr>
      <tr>
        <td id="L91" class="blob-num js-line-number" data-line-number="91"></td>
        <td id="LC91" class="blob-code js-file-line">        <span class="o">|</span> <span class="o">:?</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Collections</span><span class="p">.</span><span class="n">IEnumerable</span> <span class="k">as</span> <span class="n">seq</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L92" class="blob-num js-line-number" data-line-number="92"></td>
        <td id="LC92" class="blob-code js-file-line">            <span class="k">let</span> <span class="nv">dg</span> <span class="o">=</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Windows</span><span class="p">.</span><span class="nn">Controls</span><span class="p">.</span><span class="n">DataGrid</span><span class="o">(</span><span class="n">AutoGenerateColumns</span><span class="o">=</span><span class="k">true</span><span class="o">,</span><span class="n">HorizontalScrollBarVisibility</span><span class="o">=</span><span class="nn">ScrollBarVisibility</span><span class="p">.</span><span class="n">Auto</span><span class="o">,</span><span class="n">VerticalScrollBarVisibility</span><span class="o">=</span><span class="nn">ScrollBarVisibility</span><span class="p">.</span><span class="n">Auto</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L93" class="blob-num js-line-number" data-line-number="93"></td>
        <td id="LC93" class="blob-code js-file-line">            <span class="k">begin</span> </td>
      </tr>
      <tr>
        <td id="L94" class="blob-num js-line-number" data-line-number="94"></td>
        <td id="LC94" class="blob-code js-file-line">                <span class="k">let</span> <span class="nv">e</span> <span class="o">=</span> <span class="n">seq</span><span class="o">.</span><span class="n">GetEnumerator</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L95" class="blob-num js-line-number" data-line-number="95"></td>
        <td id="LC95" class="blob-code js-file-line">                <span class="k">use</span> <span class="o">_</span><span class="n">e</span> <span class="o">=</span> <span class="o">(</span><span class="n">e</span> <span class="o">:?&gt;</span> <span class="nn">System</span><span class="p">.</span><span class="n">IDisposable</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L96" class="blob-num js-line-number" data-line-number="96"></td>
        <td id="LC96" class="blob-code js-file-line">                <span class="k">if</span> <span class="n">e</span><span class="o">.</span><span class="n">MoveNext</span><span class="bp">()</span> <span class="k">then</span> </td>
      </tr>
      <tr>
        <td id="L97" class="blob-num js-line-number" data-line-number="97"></td>
        <td id="LC97" class="blob-code js-file-line">                    <span class="k">let</span> <span class="nv">sampleObj</span> <span class="o">=</span> <span class="n">e</span><span class="o">.</span><span class="n">Current</span></td>
      </tr>
      <tr>
        <td id="L98" class="blob-num js-line-number" data-line-number="98"></td>
        <td id="LC98" class="blob-code js-file-line">                    <span class="k">match</span> <span class="n">sampleObj</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L99" class="blob-num js-line-number" data-line-number="99"></td>
        <td id="LC99" class="blob-code js-file-line">                    <span class="o">|</span> <span class="k">null</span> <span class="o">-&gt;</span> <span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L100" class="blob-num js-line-number" data-line-number="100"></td>
        <td id="LC100" class="blob-code js-file-line">                    <span class="o">|</span>  <span class="o">_</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L101" class="blob-num js-line-number" data-line-number="101"></td>
        <td id="LC101" class="blob-code js-file-line">                        <span class="k">let</span> <span class="nv">props</span> <span class="o">=</span> <span class="n">propsOfObj</span> <span class="n">sampleObj</span></td>
      </tr>
      <tr>
        <td id="L102" class="blob-num js-line-number" data-line-number="102"></td>
        <td id="LC102" class="blob-code js-file-line">                        <span class="k">let</span> <span class="nv">props</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L103" class="blob-num js-line-number" data-line-number="103"></td>
        <td id="LC103" class="blob-code js-file-line">                            <span class="n">props</span> <span class="o">|&gt;</span> <span class="nn">List</span><span class="p">.</span><span class="n">sortBy</span> <span class="o">(</span><span class="k">fun</span> <span class="o">(</span><span class="n">propName</span><span class="o">,</span><span class="n">propType</span><span class="o">,_</span><span class="n">propGetter</span><span class="o">)</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L104" class="blob-num js-line-number" data-line-number="104"></td>
        <td id="LC104" class="blob-code js-file-line">                                <span class="k">match</span> <span class="n">propName</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L105" class="blob-num js-line-number" data-line-number="105"></td>
        <td id="LC105" class="blob-code js-file-line">                                <span class="o">|</span> <span class="s">&quot;Name&quot;</span> <span class="o">-&gt;</span> <span class="o">(</span><span class="mi">0</span><span class="o">,</span><span class="s">&quot;&quot;</span><span class="o">)</span> </td>
      </tr>
      <tr>
        <td id="L106" class="blob-num js-line-number" data-line-number="106"></td>
        <td id="LC106" class="blob-code js-file-line">                                <span class="o">|</span> <span class="s">&quot;MainImage&quot;</span> <span class="o">-&gt;</span> <span class="o">(</span><span class="mi">1</span><span class="o">,</span><span class="s">&quot;&quot;</span><span class="o">)</span> </td>
      </tr>
      <tr>
        <td id="L107" class="blob-num js-line-number" data-line-number="107"></td>
        <td id="LC107" class="blob-code js-file-line">                                <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> <span class="o">(</span><span class="mi">2</span><span class="o">,</span><span class="n">propName</span><span class="o">))</span></td>
      </tr>
      <tr>
        <td id="L108" class="blob-num js-line-number" data-line-number="108"></td>
        <td id="LC108" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L109" class="blob-num js-line-number" data-line-number="109"></td>
        <td id="LC109" class="blob-code js-file-line">                        <span class="k">for</span> <span class="n">propertyName</span><span class="o">,</span><span class="n">propType</span><span class="o">,_</span><span class="n">propGetter</span> <span class="k">in</span> <span class="n">props</span> <span class="k">do</span> </td>
      </tr>
      <tr>
        <td id="L110" class="blob-num js-line-number" data-line-number="110"></td>
        <td id="LC110" class="blob-code js-file-line">                             <span class="k">match</span> <span class="n">propertyName</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L111" class="blob-num js-line-number" data-line-number="111"></td>
        <td id="LC111" class="blob-code js-file-line">                             <span class="o">|</span> <span class="s">&quot;MainImage&quot;</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L112" class="blob-num js-line-number" data-line-number="112"></td>
        <td id="LC112" class="blob-code js-file-line">                                <span class="k">let</span> <span class="nv">img</span> <span class="o">=</span> <span class="n">FrameworkElementFactory</span><span class="o">(</span><span class="n">typeof</span><span class="o">&lt;</span><span class="n">Image</span><span class="o">&gt;)</span></td>
      </tr>
      <tr>
        <td id="L113" class="blob-num js-line-number" data-line-number="113"></td>
        <td id="LC113" class="blob-code js-file-line">                                <span class="n">img</span><span class="o">.</span><span class="n">SetValue</span><span class="o">(</span><span class="nn">Image</span><span class="p">.</span><span class="n">MaxWidthProperty</span><span class="o">,</span> <span class="mi">250</span><span class="o">.</span><span class="mi">0</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L114" class="blob-num js-line-number" data-line-number="114"></td>
        <td id="LC114" class="blob-code js-file-line">                                <span class="n">img</span><span class="o">.</span><span class="n">SetValue</span><span class="o">(</span><span class="nn">Image</span><span class="p">.</span><span class="n">MaxHeightProperty</span><span class="o">,</span> <span class="mi">120</span><span class="o">.</span><span class="mi">0</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L115" class="blob-num js-line-number" data-line-number="115"></td>
        <td id="LC115" class="blob-code js-file-line">                                <span class="n">img</span><span class="o">.</span><span class="n">SetValue</span><span class="o">(</span><span class="nn">Image</span><span class="p">.</span><span class="n">StretchProperty</span><span class="o">,</span> <span class="nn">Stretch</span><span class="p">.</span><span class="n">Uniform</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L116" class="blob-num js-line-number" data-line-number="116"></td>
        <td id="LC116" class="blob-code js-file-line">                                <span class="n">img</span><span class="o">.</span><span class="n">SetBinding</span><span class="o">(</span><span class="nn">Image</span><span class="p">.</span><span class="n">SourceProperty</span><span class="o">,</span> <span class="n">Binding</span> <span class="n">propertyName</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L117" class="blob-num js-line-number" data-line-number="117"></td>
        <td id="LC117" class="blob-code js-file-line">                                <span class="k">let</span> <span class="nv">cellTemplate</span> <span class="o">=</span> <span class="n">DataTemplate</span><span class="o">(</span><span class="n">VisualTree</span><span class="o">=</span><span class="n">img</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L118" class="blob-num js-line-number" data-line-number="118"></td>
        <td id="LC118" class="blob-code js-file-line">                           </td>
      </tr>
      <tr>
        <td id="L119" class="blob-num js-line-number" data-line-number="119"></td>
        <td id="LC119" class="blob-code js-file-line">                                <span class="k">let</span> <span class="nv">templateColumn</span> <span class="o">=</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Windows</span><span class="p">.</span><span class="nn">Controls</span><span class="p">.</span><span class="n">DataGridTemplateColumn</span><span class="o">(</span><span class="n">Header</span><span class="o">=</span><span class="n">propertyName</span><span class="o">,</span><span class="n">CellTemplate</span><span class="o">=</span><span class="n">cellTemplate</span><span class="o">,</span><span class="n">CanUserResize</span><span class="o">=</span><span class="k">true</span><span class="o">,</span><span class="n">CanUserReorder</span><span class="o">=</span><span class="k">true</span><span class="o">,</span><span class="n">CanUserSort</span><span class="o">=</span><span class="k">false</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L120" class="blob-num js-line-number" data-line-number="120"></td>
        <td id="LC120" class="blob-code js-file-line">                                <span class="n">dg</span><span class="o">.</span><span class="n">Columns</span><span class="o">.</span><span class="n">Add</span> <span class="n">templateColumn</span></td>
      </tr>
      <tr>
        <td id="L121" class="blob-num js-line-number" data-line-number="121"></td>
        <td id="LC121" class="blob-code js-file-line">                             <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L122" class="blob-num js-line-number" data-line-number="122"></td>
        <td id="LC122" class="blob-code js-file-line">                                 <span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L123" class="blob-num js-line-number" data-line-number="123"></td>
        <td id="LC123" class="blob-code js-file-line">                                 <span class="k">let</span> <span class="nv">canSort</span> <span class="o">=</span> <span class="n">typeof</span><span class="o">&lt;</span><span class="nn">System</span><span class="p">.</span><span class="n">IComparable</span><span class="o">&gt;.</span><span class="n">IsAssignableFrom</span><span class="o">(</span><span class="n">propType</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L124" class="blob-num js-line-number" data-line-number="124"></td>
        <td id="LC124" class="blob-code js-file-line">                                 <span class="k">let</span> <span class="nv">b</span> <span class="o">=</span> <span class="n">Binding</span><span class="o">(</span><span class="n">propertyName</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L125" class="blob-num js-line-number" data-line-number="125"></td>
        <td id="LC125" class="blob-code js-file-line">                                 <span class="n">b</span><span class="o">.</span><span class="n">Converter</span> <span class="o">&lt;-</span> </td>
      </tr>
      <tr>
        <td id="L126" class="blob-num js-line-number" data-line-number="126"></td>
        <td id="LC126" class="blob-code js-file-line">                                     <span class="o">{</span> <span class="k">new</span> <span class="n">IValueConverter</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L127" class="blob-num js-line-number" data-line-number="127"></td>
        <td id="LC127" class="blob-code js-file-line">                                          <span class="k">member</span> <span class="n">x</span><span class="p">.</span><span class="nf">Convert</span><span class="o">(</span><span class="kt">obj</span><span class="o">,</span><span class="n">ty</span><span class="o">,</span><span class="n">param</span><span class="o">,</span><span class="n">culture</span><span class="o">)</span> <span class="o">=</span> <span class="n">convertPropertyOfObjToText</span> <span class="kt">obj</span> <span class="o">|&gt;</span> <span class="n">box</span></td>
      </tr>
      <tr>
        <td id="L128" class="blob-num js-line-number" data-line-number="128"></td>
        <td id="LC128" class="blob-code js-file-line">                                          <span class="k">member</span> <span class="n">x</span><span class="p">.</span><span class="nf">ConvertBack</span><span class="o">(</span><span class="kt">obj</span><span class="o">,</span><span class="n">ty</span><span class="o">,</span><span class="n">param</span><span class="o">,</span><span class="n">culture</span><span class="o">)</span> <span class="o">=</span> <span class="nn">Binding</span><span class="p">.</span><span class="n">DoNothing</span> <span class="o">}</span> </td>
      </tr>
      <tr>
        <td id="L129" class="blob-num js-line-number" data-line-number="129"></td>
        <td id="LC129" class="blob-code js-file-line">                                 <span class="k">let</span> <span class="nv">c</span> <span class="o">=</span> <span class="n">DataGridTextColumn</span><span class="o">(</span><span class="n">Header</span><span class="o">=</span><span class="n">propertyName</span><span class="o">,</span><span class="n">Binding</span><span class="o">=</span><span class="n">b</span><span class="o">,</span><span class="n">MaxWidth</span><span class="o">=</span><span class="mi">200</span><span class="o">.</span><span class="mi">0</span><span class="o">,</span><span class="n">CanUserResize</span><span class="o">=</span><span class="k">true</span><span class="o">,</span><span class="n">CanUserReorder</span><span class="o">=</span><span class="k">true</span><span class="o">,</span><span class="n">CanUserSort</span><span class="o">=</span><span class="n">canSort</span><span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L130" class="blob-num js-line-number" data-line-number="130"></td>
        <td id="LC130" class="blob-code js-file-line">                                 <span class="n">dg</span><span class="o">.</span><span class="n">Columns</span><span class="o">.</span><span class="n">Add</span> <span class="n">c</span></td>
      </tr>
      <tr>
        <td id="L131" class="blob-num js-line-number" data-line-number="131"></td>
        <td id="LC131" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L132" class="blob-num js-line-number" data-line-number="132"></td>
        <td id="LC132" class="blob-code js-file-line">            <span class="k">end</span></td>
      </tr>
      <tr>
        <td id="L133" class="blob-num js-line-number" data-line-number="133"></td>
        <td id="LC133" class="blob-code js-file-line">            <span class="k">let</span> <span class="nv">ct</span> <span class="o">=</span> <span class="n">cancelPrevious</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L134" class="blob-num js-line-number" data-line-number="134"></td>
        <td id="LC134" class="blob-code js-file-line">            <span class="n">dg</span><span class="o">.</span><span class="n">ItemsSource</span> <span class="o">&lt;-</span> <span class="n">seq</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">cast</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">truncate</span> <span class="mi">50</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">map</span> <span class="n">probeObj</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">toObservableCollection</span> <span class="n">ct</span></td>
      </tr>
      <tr>
        <td id="L135" class="blob-num js-line-number" data-line-number="135"></td>
        <td id="LC135" class="blob-code js-file-line">            <span class="n">box</span> <span class="n">dg</span></td>
      </tr>
      <tr>
        <td id="L136" class="blob-num js-line-number" data-line-number="136"></td>
        <td id="LC136" class="blob-code js-file-line">        <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> </td>
      </tr>
      <tr>
        <td id="L137" class="blob-num js-line-number" data-line-number="137"></td>
        <td id="LC137" class="blob-code js-file-line">            <span class="kt">obj</span></td>
      </tr>
      <tr>
        <td id="L138" class="blob-num js-line-number" data-line-number="138"></td>
        <td id="LC138" class="blob-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L139" class="blob-num js-line-number" data-line-number="139"></td>
        <td id="LC139" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">show</span> <span class="n">x</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L140" class="blob-num js-line-number" data-line-number="140"></td>
        <td id="LC140" class="blob-code js-file-line">    <span class="k">let</span> <span class="nv">viewer</span> <span class="o">=</span> <span class="n">ScrollViewer</span><span class="bp">()</span></td>
      </tr>
      <tr>
        <td id="L141" class="blob-num js-line-number" data-line-number="141"></td>
        <td id="LC141" class="blob-code js-file-line">    <span class="k">let</span> <span class="nv">x</span> <span class="o">=</span> </td>
      </tr>
      <tr>
        <td id="L142" class="blob-num js-line-number" data-line-number="142"></td>
        <td id="LC142" class="blob-code js-file-line">        <span class="k">match</span> <span class="n">box</span> <span class="n">x</span> <span class="k">with</span> </td>
      </tr>
      <tr>
        <td id="L143" class="blob-num js-line-number" data-line-number="143"></td>
        <td id="LC143" class="blob-code js-file-line">        <span class="o">|</span> <span class="o">:?</span> <span class="nn">System</span><span class="p">.</span><span class="nn">Collections</span><span class="p">.</span><span class="n">IEnumerable</span> <span class="k">as</span> <span class="n">e</span> <span class="o">-&gt;</span> <span class="n">e</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">cast</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">truncate</span> <span class="mi">100</span> <span class="o">|&gt;</span> <span class="nn">Seq</span><span class="p">.</span><span class="n">toList</span> <span class="o">|&gt;</span> <span class="n">box</span></td>
      </tr>
      <tr>
        <td id="L144" class="blob-num js-line-number" data-line-number="144"></td>
        <td id="LC144" class="blob-code js-file-line">        <span class="o">|</span> <span class="o">_</span> <span class="o">-&gt;</span> <span class="n">x</span></td>
      </tr>
      <tr>
        <td id="L145" class="blob-num js-line-number" data-line-number="145"></td>
        <td id="LC145" class="blob-code js-file-line">    <span class="k">let</span> <span class="nv">s</span> <span class="o">=</span> <span class="n">sprintf</span> <span class="s">&quot;%40A&quot;</span> <span class="n">x</span></td>
      </tr>
      <tr>
        <td id="L146" class="blob-num js-line-number" data-line-number="146"></td>
        <td id="LC146" class="blob-code js-file-line">    <span class="n">viewer</span><span class="o">.</span><span class="n">Content</span> <span class="o">&lt;-</span> <span class="n">TextBlock</span><span class="o">(</span><span class="n">Text</span><span class="o">=</span><span class="n">s</span> <span class="o">,</span> <span class="n">Margin</span><span class="o">=</span> <span class="n">Thickness</span><span class="o">(</span><span class="mi">0</span><span class="o">.</span><span class="mi">0</span><span class="o">,</span><span class="mi">0</span><span class="o">.</span><span class="mi">0</span><span class="o">,</span><span class="mi">0</span><span class="o">.</span><span class="mi">0</span><span class="o">,</span><span class="mi">0</span><span class="o">.</span><span class="mi">0</span><span class="o">)</span> <span class="o">)</span></td>
      </tr>
      <tr>
        <td id="L147" class="blob-num js-line-number" data-line-number="147"></td>
        <td id="LC147" class="blob-code js-file-line">    <span class="n">win</span><span class="o">.</span><span class="n">Content</span> <span class="o">&lt;-</span> <span class="n">viewer</span></td>
      </tr>
      <tr>
        <td id="L148" class="blob-num js-line-number" data-line-number="148"></td>
        <td id="LC148" class="blob-code js-file-line">    </td>
      </tr>
      <tr>
        <td id="L149" class="blob-num js-line-number" data-line-number="149"></td>
        <td id="LC149" class="blob-code js-file-line"><span class="k">let</span> <span class="nv">teeGrid</span> <span class="n">x</span> <span class="o">=</span> <span class="n">showGrid</span> <span class="n">x</span><span class="o">;</span> <span class="n">x</span></td>
      </tr>
</table>

  </div>

  </div>
</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="button">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer">
    <ul class="site-footer-links right">
      <li><a href="https://status.github.com/">Status</a></li>
      <li><a href="http://developer.github.com">API</a></li>
      <li><a href="http://training.github.com">Training</a></li>
      <li><a href="http://shop.github.com">Shop</a></li>
      <li><a href="/blog">Blog</a></li>
      <li><a href="/about">About</a></li>

    </ul>

    <a href="/" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
    </a>

    <ul class="site-footer-links">
      <li>&copy; 2014 <span title="0.04980s from github-fe125-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="/site/terms">Terms</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
        <li><a href="/contact">Contact</a></li>
    </ul>
  </div><!-- /.site-footer -->
</div><!-- /.container -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents js-suggester-field" placeholder=""></textarea>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-2b4202fc62ef88e1a007a9ed05df10607b189f42.js" type="text/javascript"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-6a94e38095c9a28d2a7b45944c43553bd4aee9ff.js" type="text/javascript"></script>
      
      
        <script async src="https://www.google-analytics.com/analytics.js"></script>
  </body>
</html>

