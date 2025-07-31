(function () {
    const requiredPrefix = "/Ibvc/";

    const currentPath = window.location.pathname;

    if (!currentPath.startsWith(requiredPrefix)) {
        const newUrl = requiredPrefix + currentPath.replace(/^\/+/, "");
        const fullUrl = window.location.origin + newUrl + window.location.search + window.location.hash;
        window.location.replace(fullUrl);
    }
})();