<?= $this->getLayoutData('startPage'); ?>
<?= $this->getLayoutData('header'); ?>
<?= $this->getLayoutData('menu'); ?>
    <div class="container">
        <?php if(isset($this->___data['errors'])){
            echo $this->getLayoutData('errors');
        } ?>

        <div class="row">
            <div class="col-md-4 col-md-offset-4 table-bordered">
                <form class="form-horizontal col-md-12" method="POST">
                    <fieldset>
                        <legend class="center">Вход</legend>
                        <div class="form-group">
                            <label for="inputUsername" class="col-md-10 control-label">Потребителско име</label>

                            <div class="col-md-12">
                                <input name="username" class="form-control" id="inputUsername" placeholder="Потребителско име"
                                       type="text">
                            </div>
                        </div>

                        <div class="form-group">
                            <label for="inputPassword" class="col-md-10 control-label">Парола</label>

                            <div class="col-md-12">
                                <input name="password" class="form-control" id="inputPassword" placeholder="Парола" type="password">
                            </div>
                        </div>

                         <div class="form-group">
                            <div class="col-md-12">
                                <button name="submit" type="submit" class="btn btn-primary">Вход</button>
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
        </div>
    </div>
<?= $this->getLayoutData('endPage'); ?>